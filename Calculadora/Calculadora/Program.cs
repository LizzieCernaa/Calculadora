using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int A = 0;
           
            Console.WriteLine("Programa para calculadora");
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1 Sumar");
            Console.WriteLine("2 Restar ");
            Console.WriteLine("3 Multiplicar ");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("Seleccione una opción");
            A = int.Parse(Console.ReadLine());

            if (A == 1)
            {
                Console.WriteLine("Ingrese el numero 1:");
                double B = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el numero 2:");
                double C = double.Parse(Console.ReadLine());

                double D = B + C;
                Console.WriteLine("El resultado de la suma es:" + D);
            }
            else if (A == 2)
            {
                    Console.WriteLine("Ingrese el numero 1:");
                    double B = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el numero 2:");
                    double C = double.Parse(Console.ReadLine());

                    double D = B + C;
                    Console.WriteLine(D);
               
            }
            Console. ReadKey();
        }
    }
}
  