using System;
using System.Collections;

namespace Cap8
{
    public class Eje8_5 {
        public static void OrdenarCadenas()
        {
            string str1;
            string str2;

            Console.Write("Ingrese la primera cadena: ");
            str1 = Console.ReadLine();

            Console.Write("Ingrese la segunda cadena: ");
            str2 = Console.ReadLine();

            Console.WriteLine();

            if(str1.ToLower().CompareTo(str2.ToLower()) <= 0)
            {
                Console.WriteLine(str1);
                Console.WriteLine(str2);
            }
            else
            {
                Console.WriteLine(str2);
                Console.WriteLine(str1);
            }
        }
    }
}