using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Escriba el número que desea revisar");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero < 0)
            {
                numero = numero * -1;
            }
           
            Console.WriteLine("Resultado: " + numero);
            Console.ReadKey();
        }
    }
}
