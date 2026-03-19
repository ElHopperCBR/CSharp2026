using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace terreno
{
    internal class Terreno
    {
        //Campos
        public double largura, comprimeto, valor;

        //Construtor
        public Terreno(double largura, double comprimeto, double valor)
        {
            this.largura = largura;
            this.comprimeto = comprimeto;
            this.valor = valor;
        }

        //Métodos
        public double Area()
        {
            return largura * comprimeto;
        }

        public double Preco()
        {
            return Area() * valor;
        }

        public void Saida()
        {
            Console.WriteLine($"Area do terreno = {Area()}");
            Console.WriteLine($"Preço do terreno = R$ {Preco()}");            
        }


    }
}
