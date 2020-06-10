using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            string resultado;

            string vocales;
            vocales = "aeiouAEIOU";

            string numeros;
            numeros = "1234567890";

            Console.WriteLine("Escriba el carácter:");
            caracter = Convert.ToChar(Console.ReadLine());

            if (Char.IsLetter(caracter))
            {
                if (vocales.IndexOf(caracter) >= 0)
                {
                    resultado = "Es vocal";
                }
                else
                {
                    resultado = "Es consonante";
                }
            }
            else
            {
                if (numeros.IndexOf(caracter) >= 0)
                {
                    resultado = "Es un numero";
                }
                else
                {
                    resultado = "Desconocido";
                }
            }

            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
