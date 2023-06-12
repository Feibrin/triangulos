// Fabrício Nogueira Santos - 11/06/23
using System;
using System.Globalization;

namespace Course
{
    public class Triangulo
    {
// Recebe variáveis      
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
// Função calcular área
        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Triangulo x = LerTriangulo("X");
            Triangulo y = LerTriangulo("Y");

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
// Verifica maior área
            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area: X");
            }
            else
            {
                Console.WriteLine("Maior Area: Y");
            }
        }
// Recebe triângulo
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            Triangulo triangulo = new Triangulo();
// Colocar as medidas
            Console.WriteLine("Entre com as medidas do triangulo " + nomeTriangulo + ":");
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return triangulo;
        }
    }
}
