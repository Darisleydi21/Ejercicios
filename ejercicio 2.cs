using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, menor;

            Console.Write("Escribe primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            menor = num1 < num2 ? num1 : num2;

            Console.WriteLine("El menor de los números es {0}.", menor);

            Console.ReadKey();
        }
    }
}
