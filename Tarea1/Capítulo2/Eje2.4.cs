using System;

namespace Cap2{
    public class Eje2_4{
        public static void Celsius_Fahrenheit()
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
