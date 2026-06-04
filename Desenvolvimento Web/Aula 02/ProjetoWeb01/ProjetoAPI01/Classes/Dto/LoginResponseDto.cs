namespace ProjetoAPI01.Classes.Dto
{
    // DTO de saída devolvido após tentativa de autenticação.
    public class LoginResponseDto
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public int Regra { get; set; }
    }
}
