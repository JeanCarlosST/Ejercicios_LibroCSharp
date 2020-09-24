using System;

namespace Cap2{
    public class Eje2_3{
        public static void Gradios_Radianes(){
            string value = "";

            Console.Write("Ingrese los grados: ");
            value = Console.ReadLine();
            float degrees = Convert.ToSingle(value);

            Console.WriteLine("Radianes: {0}", (degrees * Math.PI /180));
            Console.ReadKey(true);
        }
    }
}