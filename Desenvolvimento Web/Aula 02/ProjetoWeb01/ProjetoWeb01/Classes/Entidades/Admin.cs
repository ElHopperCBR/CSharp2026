using ProjetoWeb01.Classes.Enumeracoes;

namespace ProjetoWeb01.Classes.Entidades
{
    public class Admin : Usuario
    {

        //public TipoRegra Regra { get; set; } = TipoRegra.Admin;

        //Retirando a propriedade Regra da classe Admin, pois ela já é herdada da classe Usuario e já tem um valor padrão definido no construtor da classe Usuario.
        //Criando um construtor para a classe Admin, onde o valor da propriedade Regra
        public Admin()
        {
            Regra = TipoRegra.Admin;
        }
    }
}
