using ProjetoWeb01.Classes.Enumeracoes;

namespace ProjetoWeb01.Classes.Entidades
{
    public abstract class Usuario
    {
        //ID, Nome, Email, Senha, Regras

        //PROP
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty; // para evitar null
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public TipoRegra Regra { get; set; }
    }
}
