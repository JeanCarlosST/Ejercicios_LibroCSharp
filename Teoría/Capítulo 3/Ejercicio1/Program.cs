using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            Console.Write("Ingrese un número: ");
            value = Console.ReadLine();
            int num = Convert.ToInt32(value);

            if(num % 2 == 0)
                Console.WriteLine("El número es par");
            else
                Console.WriteLine("El número es impar");

            Console.ReadKey(true);
        }
    }
}
