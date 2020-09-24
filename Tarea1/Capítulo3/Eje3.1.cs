using System;

namespace Cap3{
    public class Eje3_1 {
        public static void Paridad() {
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
