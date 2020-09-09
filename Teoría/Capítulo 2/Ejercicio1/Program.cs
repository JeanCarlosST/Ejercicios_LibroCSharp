using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";

            Console.Write("Ingrese el número de lados del polígono: ");
            value = Console.ReadLine();
            int edges = Convert.ToInt32(value);

            Console.Write("Ingrese la longitud de los lados: ");
            value = Console.ReadLine();
            float perimeter = Convert.ToSingle(value) * edges;
           
            Console.WriteLine("Perímetro del polígono: {0}", perimeter);
            Console.ReadKey(true);
        }
    }
}
