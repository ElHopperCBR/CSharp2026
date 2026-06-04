using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace AplicativoDesktop01
{
    public partial class TelaLogin : Form
    {
        private static readonly HttpClient _httpClient = new();

        public TelaLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var login = new LoginRequestDto
            {
                Nome = textBox1.Text.Trim(),
                Senha = textBox2.Text.Trim()
            };

            if (string.IsNullOrWhiteSpace(login.Nome) || string.IsNullOrWhiteSpace(login.Senha))
            {
                MessageBox.Show("Informe usuário e senha.");
                return;
            }

            try
            {
                var resposta = await _httpClient.PostAsJsonAsync("https://localhost:7074/api/usuarios/login", login);

                if (resposta.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                    return;
                }

                if (!resposta.IsSuccessStatusCode)
                {
                    var erro = await resposta.Content.ReadAsStringAsync();
                    MessageBox.Show($"Não foi possível autenticar. Detalhes: {erro}");
                    return;
                }

                var resultado = await resposta.Content.ReadFromJsonAsync<LoginResponseDto>();

                if (resultado is null || !resultado.Sucesso)
                {
                    MessageBox.Show("Falha no login.");
                    return;
                }

                if (resultado.Regra != 1)
                {
                    MessageBox.Show("Acesso negado: este usuário não possui regra de administrador (Regra = 1).");
                    return;
                }

                MessageBox.Show("Login realizado com sucesso.");

                this.Hide(); // esconde a tela de login
                using (var telaAdmin = new TelaAdmin())
                {
                    telaAdmin.ShowDialog(); // abre a tela admin
                }
                this.Close(); // fecha login quando admin for fechada
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Não foi possível conectar na API. Confirme se o ApiUsuarios01 está em execução.");
            }
            catch (JsonException)
            {
                MessageBox.Show("A resposta da API está em formato inválido.");
            }
        }
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
}
