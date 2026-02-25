using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_resta
{
    internal class Suma_resta
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int suma = num1 + num2;
            int resta = num1 - num2;
            Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
            Console.WriteLine($"La resta de {num1} y {num2} es: {resta}");
            Console.ReadKey();
        }
    }
}
