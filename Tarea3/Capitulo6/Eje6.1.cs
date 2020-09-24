using System;

namespace Cap6{
    
    public class Eje6_1 {

        private static int cantidad = 0;
        private static int salones = 0;
        private static float[][] calif;
        private static float sum = 0;
        private static float avg = 0;
        public static void PromedioJagged(){

            Console.Write("Ingrese la cantidad de salones: ");
            salones = Convert.ToInt32(Console.ReadLine());
            calif = new float [salones][];

            int stdCant = 0;

            for(int i = 0; i < salones; i++)
            {
                Console.Write("Ingrese la cantidad de alumnos para el salon {0}: ", i+1);
                cantidad = Convert.ToInt32(Console.ReadLine());
                calif[i] = new float[cantidad];
                stdCant += cantidad;
            }

            for(int i = 0; i < salones; i++)
            {
                Console.WriteLine("\nSalon {0}", i);
                for(int j = 0; j < calif[i].Length; j++)
                {
                    Console.Write("Ingrese la calificación: ");
                    float value = Convert.ToSingle(Console.ReadLine());
                    calif[i][j] = value;
                    sum += value;
                }
                Console.WriteLine();
            }

            avg = sum/stdCant;

            Console.WriteLine("\n—— Información ——");

            for (int i = 0; i < salones; i++) 
            {
                Console.WriteLine("Salon {0}", i);
                for (int j = 0; j < calif[i].Length; j++) 
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", j, calif[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Promedio: {0}", avg);
        }
    }
}