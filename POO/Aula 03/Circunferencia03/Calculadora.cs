namespace Circunferencia03
{
    internal static class Calculadora
    {
        //Campos da classe estática
        public static double PI = 3.14;
        

        //Métodos
        public static double Circunferencia(double raio)
        {
            return 2 * PI * raio;
        }

        public static double Volume(double raio)
        {
            return (4 / 3) * PI * Math.Pow(raio, 3);
        }
    }
}
