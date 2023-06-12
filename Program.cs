// Fabrício Nogueira Santos - 11/06/23
using System;
using System.Globalization;

namespace Course
{

    public class Program
    {

        public static void Main(string[] args)
        {
// Declaração de variáveis (medidas e áreas)
            double[] medidaX = LerMedidasTriangulo("X");
            double[] medidaY = LerMedidasTriangulo("Y");

            double areaX = CalcularAreaTriangulo(medidaX);
            double areaY = CalcularAreaTriangulo(medidaY);
            
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
// Verifica a maior área
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
// Função recebe medidas       
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
 // Cria array          
            double[] medidas = new double[3];
// Recebe valores (3 vezes, pelo for)
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            for (int i = 0; i < 3; i++)
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
// Retorna para medidas do triângulo
            return medidas;
        }
// Função calcular área
        public static double CalcularAreaTriangulo(double[] medidas)
        {
// Recebe valores (lados)           
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];
// Cálculo
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}
