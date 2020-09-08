using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            Console.Write("Ingrese la equivalencia del USD/EUR: ");
            value = Console.ReadLine();
            float exg = Convert.ToSingle(value);

            Console.Write("Ingrese la cantidad de dólares: ");
            value = Console.ReadLine();
            float usd = Convert.ToSingle(value);

            Console.WriteLine("Euros: {0}", usd * exg);
            Console.ReadKey(true);
        }
    }
}
