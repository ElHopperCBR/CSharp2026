using Microsoft.Data.SqlClient;
using ProjetoAPI01.Classes.Dto;

namespace ProjetoAPI01.Classes.Repositorio
{
    public class RepositorioUsuario
    {
        private readonly string stringConexao;

        public RepositorioUsuario(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        // Consulta usuário por e-mail e senha, retornando somente os dados necessários para o login.
        public async Task<UsuarioDto?> BuscarPorEmailESenhaAsync(string email, string senha, CancellationToken cancellationToken)
        {
            await using var conexao = new SqlConnection(stringConexao);
            await conexao.OpenAsync(cancellationToken);

            const string comandoSql = """
                SELECT TOP 1 Id, Nome, Regra
                FROM Usuario
                WHERE Email = @email AND Senha = @senha
                """;

            await using var comando = new SqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senha);

            await using var leitor = await comando.ExecuteReaderAsync(cancellationToken);

            if (!await leitor.ReadAsync(cancellationToken))
            {
                return null;
            }

            return new UsuarioDto
            {
                Id = leitor.GetInt32(leitor.GetOrdinal("Id")),
                Nome = leitor.GetString(leitor.GetOrdinal("Nome")),
                Regra = leitor.GetInt32(leitor.GetOrdinal("Regra"))
            };
        }
    }
}
