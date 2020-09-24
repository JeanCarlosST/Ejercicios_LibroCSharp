using System;

namespace Cap6{
    
    public class Eje6_4 {

        private static int cantidad = 0;
        private static int cantidadTotal = 0;
        private static int salones = 0;
        private static float[][] calif;
        private static float sum = 0;
        private static float avg = 0;
        private static float min = 0;
        private static float max = 0;
        public static void JaggedWithFunctions(){

            ReadSizes();
            ReadData();
            PrintCalifications();
            PrintStatistics();
        }

        private static void ReadSizes(){
            Console.Write("Ingrese la cantidad de salones: ");
            salones = Convert.ToInt32(Console.ReadLine());
            calif = new float [salones][];

            for(int i = 0; i < salones; i++)
            {
                Console.Write("Ingrese la cantidad de alumnos para el salon {0}: ", i+1);
                cantidad = Convert.ToInt32(Console.ReadLine());
                calif[i] = new float[cantidad];
                cantidadTotal += cantidad;
            }
        }

        private static void ReadData(){
            for(int i = 0; i < salones; i++)
            {
                Console.WriteLine("\nSalon {0}", i);
                for(int j = 0; j < calif[i].Length; j++)
                {
                    Console.Write("Ingrese la calificación: ");
                    float value = Convert.ToSingle(Console.ReadLine());
                    calif[i][j] = value;
                    sum += value;

                    if(i == 0 && j == 0) max = min = value;
                    if(value < min) min = value;
                    if(value > max) max = value;
                }
                Console.WriteLine();
            }

            avg = sum/cantidadTotal;
        }

        private static void PrintCalifications(){
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
        }

        private static void PrintStatistics(){
            Console.WriteLine("Promedio: {0}", avg);
            Console.WriteLine("Calificación mínima: {0}", min);
            Console.WriteLine("Calificación máxima: {0}", max);
        }
    }
}