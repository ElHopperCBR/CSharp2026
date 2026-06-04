using Microsoft.AspNetCore.Mvc;
using ProjetoAPI01.Classes.Dto;
using ProjetoAPI01.Classes.Repositorio;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

var stringConexaoBancoAluno = builder.Configuration.GetConnectionString("BancoAluno")
    ?? throw new InvalidOperationException("A string de conexão 'BancoAluno' não foi encontrada no appsettings.json.");

// Configura a serialização JSON para melhorar o desempenho na API.
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

// Registra o serviço responsável por consultar usuários no banco de dados.
builder.Services.AddScoped(_ => new RepositorioUsuario(stringConexaoBancoAluno));

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

var grupoUsuarios = app.MapGroup("/api/usuarios");//


// Endpoint REST responsável por autenticar o usuário.
grupoUsuarios.MapPost("/login", async Task<IResult> (
    [FromBody] LoginRequestDto dadosLogin,
    RepositorioUsuario repositorioUsuario,
    CancellationToken cancellationToken) => //CancellationToken é opcional, mas recomendado para operações assíncronas que podem ser canceladas, como consultas ao banco de dados.
{
    // Validações básicas para garantir dados mínimos antes de consultar o banco.
    if (string.IsNullOrWhiteSpace(dadosLogin.Email) || string.IsNullOrWhiteSpace(dadosLogin.Senha))
    {
        return Results.BadRequest(new LoginResponseDto
        {
            Sucesso = false,
            Mensagem = "E-mail e senha são obrigatórios."
        });
    }
    }

    var usuario = await repositorioUsuario.BuscarPorEmailESenhaAsync(
        dadosLogin.Email,
        dadosLogin.Senha,
        cancellationToken);

    if (usuario is null)
    {
        return Results.Unauthorized();
    }

    return Results.Ok(new LoginResponseDto
    {
        Sucesso = true,
        Mensagem = "Login realizado com sucesso.",
        Nome = usuario.Nome,
        Regra = usuario.Regra
    });
})
.WithName("LoginUsuario");

app.Run();

[JsonSerializable(typeof(LoginRequestDto))]
[JsonSerializable(typeof(LoginResponseDto))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
