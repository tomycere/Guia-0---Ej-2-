using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_0___Ej_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número entero: ");
            string cadena1 = Console.ReadLine();
            int.TryParse(cadena1, out int num1);
            Console.Write("Ingrese el segundo número entero:");
            string cadena2 = Console.ReadLine();
            int.TryParse(cadena2, out int num2);
            Console.WriteLine();
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(Math.Pow(num1,num2));
            Console.WriteLine(num1 % num2);

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese el primer número decimal:");
            string cadena3 = Console.ReadLine();
            decimal.TryParse(cadena3, out decimal dec1);
            Console.Write("Ingrese el segundo número decimal:");
            string cadena4 = Console.ReadLine();
            decimal.TryParse(cadena4, out decimal dec2);
            Console.WriteLine();

            Console.WriteLine(dec1 + dec2);
            Console.WriteLine(dec1 - dec2);
            Console.WriteLine(dec1 * dec2);
            //Console.WriteLine(Math.Pow(dec1, dec2));//
            Console.WriteLine(dec1 % dec2);
            Console.WriteLine(dec1 / dec2);
            Console.WriteLine(dec2 / dec1);

            Console.ReadKey();


        }
    }
}
