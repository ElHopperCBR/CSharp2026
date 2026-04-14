using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
		//Campos
		private double largura;
		private double altura;


        //Propriedades
        protected double Largura
		{
			get { return largura; }
			set { largura = value; }
		}
		protected double Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		//Construtor
        public Retangulo(Cor corDaForma, double largura, double altura) : base(corDaForma)
        {
			Largura = largura;
			Altura = altura;
        }
        /// <summary>
        ///		Calcula a área da forma usando as dimensões atuais.
        /// </summary>
        /// <returns>O valor da área calculada com base na largura e altura do retângulo.</returns>
        public override double Area() => Largura * Altura;

  

    }
}
