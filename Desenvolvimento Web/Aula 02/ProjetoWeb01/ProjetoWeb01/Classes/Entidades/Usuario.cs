using ProjetoWeb01.Classes.Enumeracoes;

namespace ProjetoWeb01.Classes.Entidades
{
    abstract public class Usuario
    {
        //ID, Nome, Email, Senha, Regras

        //PROP
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoRegra Regra { get; set; }
    }
}
