using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<UsuarioContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/api/usuarios/login", async (LoginRequestDto requisicao, UsuarioContext db) =>
{
    if (string.IsNullOrWhiteSpace(requisicao.Nome) || string.IsNullOrWhiteSpace(requisicao.Senha))
    {
        return Results.BadRequest(new LoginResponseDto
        {
            Sucesso = false,
            Mensagem = "Informe usuário e senha."
        });
    }

    var usuario = await db.Usuarios
        .AsNoTracking()
        .FirstOrDefaultAsync(u => u.Nome == requisicao.Nome && u.Senha == requisicao.Senha);

    if (usuario is null)
    {
        return Results.Json(new LoginResponseDto
        {
            Sucesso = false,
            Mensagem = "Usuário ou senha inválidos."
        }, statusCode: StatusCodes.Status401Unauthorized);
    }

    return Results.Ok(new LoginResponseDto
    {
        Sucesso = true,
        Mensagem = "Login realizado com sucesso.",
        Nome = usuario.Nome,
        Regra = usuario.Regra
    });
});

app.Run();

public class UsuarioContext : DbContext
{
    public DbSet<Usuario> Usuarios => Set<Usuario>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\MSSQLLocalDB;Database=Aluno;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>().ToTable("Usuario");

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.Senha).IsRequired();
            entity.Property(e => e.Regra).IsRequired();
        });
    }
}

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public int Regra { get; set; }
}

public class LoginRequestDto
{
    public string Nome { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}

public class LoginResponseDto
{
    public bool Sucesso { get; set; }
    public string Mensagem { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public int Regra { get; set; }
}
