using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";

            Console.Write("Ingrese los grados en centígrados: ");
            value = Console.ReadLine();
            float celsiusDegrees = Convert.ToSingle(value);

            Console.WriteLine("Grados Fahrenheit: {0}", (celsiusDegrees * 9/5 + 32));
            Console.ReadKey(true);
        }
    }
}
