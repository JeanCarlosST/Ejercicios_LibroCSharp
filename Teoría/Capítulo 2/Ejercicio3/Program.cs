using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";

            Console.Write("Ingrese los grados: ");
            value = Console.ReadLine();
            float degrees = Convert.ToSingle(value);

            Console.WriteLine("Radianes: {0}", (degrees * Math.PI /180));
            Console.ReadKey(true);
        }
    }
}
