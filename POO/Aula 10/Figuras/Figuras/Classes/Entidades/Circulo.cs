using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    internal class Circulo : Forma
    {
		//Campo
		private double raio;


        //Propriedade
        public double Raio
		{
			get { return raio; }
			set { raio = value; }
		}

        //Construtor
        public Circulo(Cor corDaForma, double raio) : base(corDaForma)
        {
            Raio = raio;
        }

        //Método
        public override double Area()
        {
            return Raio * Raio * 3.14;
        }

	}
}
