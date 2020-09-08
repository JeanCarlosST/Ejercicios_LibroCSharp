using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            float perimeter = 0.0f;

            Console.Write("Ingrese el número de lados del polígono: ");
            value = Console.ReadLine();
            int edges = Convert.ToInt32(value);

            Console.WriteLine("Lados: {0}", edges);

            for(int i = 0; i < edges; i++){
                Console.Write("Ingrese la longitud del lado no. {0}: ", (i+1));
                value = Console.ReadLine();
                perimeter += Convert.ToSingle(value);
            }

            Console.WriteLine("Perímetro del polígono: {0}", perimeter);
            Console.ReadKey(true);
        }
    }
}
