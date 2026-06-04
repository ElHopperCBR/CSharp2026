namespace ProjetoAPI01.Classes.Dto
{
    // DTO interno com dados essenciais do usuário consultado no banco.
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Regra { get; set; }
    }
}
