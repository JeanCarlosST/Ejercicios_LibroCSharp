using System;
using System.Diagnostics;

namespace Cap12
{
    public class Eje12_2
    {
        public static void Factorial()
        {
            Debug.WriteLine("Entrada al método principal de Factorial");

            Console.Write("Ingrese un numero: ");

            Console.WriteLine("Factorial: " + Factorial(Convert.ToInt32(Console.ReadLine())));

            Debug.WriteLine("Salida al método principal de Factorial");
        }

        private static int Factorial(int n)
        {
            Debug.WriteLine("Entrada al método del cálculo del Factorial");
            Debug.WriteLine("Valor de n:" + n);

            if(n <= 1)
                return 1;

            Debug.WriteLine("Salida al método del cálculo del Factorial");
            return n * Factorial(n-1);
        }
    }
}