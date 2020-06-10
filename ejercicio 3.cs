using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            string resultado;

            string signo;
            signo = ",.:;_-¿?¡![]()*¨ʼ";

            string numeros;
            numeros = "1234567890";

            Console.WriteLine("Escriba el carácter:");
            caracter = Convert.ToChar(Console.ReadLine());

            if (Char.IsPunctuation(caracter))
            {
                if (signo.IndexOf(caracter) >= 0)
                {
                    resultado = "Es un signo de puntuacion";
                }
                else
                {
                    resultado = "Es otro caracter";
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
                    resultado = "Es otro caracter";
                }
            }

            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
