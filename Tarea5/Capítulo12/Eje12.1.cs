using System;

namespace Cap12
{
    public class Eje12_1
    {
        public static void Factorial()
        {
            Console.Write("Ingrese un numero: ");
            Console.WriteLine("Factorial: " + Factorial(Convert.ToInt32(Console.ReadLine())));
        }

        private static int Factorial(int n)
        {
            if(n <= 1)
                return 1;

            return n * Factorial(n-1);
        }
    }
}