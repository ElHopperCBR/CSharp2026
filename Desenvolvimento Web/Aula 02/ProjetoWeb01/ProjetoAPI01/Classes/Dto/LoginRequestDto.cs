namespace ProjetoAPI01.Classes.Dto
{
    // DTO de entrada usado no endpoint de login.
    public class LoginRequestDto
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}
