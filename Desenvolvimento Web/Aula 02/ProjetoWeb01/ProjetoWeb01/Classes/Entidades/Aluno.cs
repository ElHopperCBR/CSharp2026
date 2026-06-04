using ProjetoWeb01.Classes.Enumeracoes;

namespace ProjetoWeb01.Classes.Entidades
{
    public class Aluno : Usuario
    {
        //PROP
        public int RA { get; set; }

        public string StatusWIFI { get; set; } = "Inativo";

        public string StatusAction { get; set; } = "Aguardando aprovação";

        public int CursoID { get; set; }
        //public Cursos CursoID { get; set; }

        //public TipoRegra Regra { get; set; } = TipoRegra.Usuario;

        //Retirando a propriedade Regra da classe Aluno, pois ela já é herdada da classe Usuario e já tem um valor padrão definido no construtor da classe Usuario.
        //Criando um construtor para a classe Aluno, onde o valor da propriedade Regra é definido como TipoRegra.Usuario, para garantir que todos os objetos do tipo Aluno tenham essa regra definida.
        public Aluno()
        {
            Regra = TipoRegra.Usuario;
        }
    }
}
