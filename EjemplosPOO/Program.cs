using System;
namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circulo miCirculo; // Creación de objetoo de tipo Círculo. Variable/Objeto de tipo círculo
            //miCirculo = new Circulo();
            //Console.WriteLine($"Area: {miCirculo.CalcularArea(5)}");

            //Circulo miCirculo2 = new Circulo();

            //Console.WriteLine($"Area: {miCirculo.CalcularArea(9)}");

            ConversorEuroDolar obj= new ConversorEuroDolar();

            obj.euro = ;

            Console.WriteLine($"Son {obj.Convierte(50)} dolares");

        }
    }

    class Circulo
    {
        private const double pi = 3.1416;

        public double CalcularArea(int radio) => pi * radio * radio;
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad) => euro * cantidad;

        public void CambioValorEuro(double nuevoValor)
        {
            if (nuevoValor >= 0) euro = nuevoValor;
        }
    }
}
