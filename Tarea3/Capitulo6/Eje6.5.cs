using System;

namespace Cap6
{
    public class Eje6_5{

        public static void JaggedParameter(){
            Console.Write("Ingrese la cantidad de sub-arreglos: ");
            int value = Convert.ToInt32(Console.ReadLine());
            int[][] array = new int [value][];

            for(int i = 0; i < value; i++)
            {
                Console.Write("Ingrese la cantidad de elementos para el sub-arreglo {0}: ", i+1);
                int cant = Convert.ToInt32(Console.ReadLine());
                array[i] = new int[cant];
            }

            for(int i = 0; i < array.Length; i++){
                for(int j = 0; j < array[i].Length; j++){
                    Console.Write("Ingrese el valor en la posicion [{0}][{1}]: ", i, j);
                    value = Convert.ToInt32(Console.ReadLine());
                    array[i][j] = value;
                }
                Console.WriteLine();
            }

            PrintJagged(array);
        }

        private static void PrintJagged(int[][] jagged){
            for(int i = 0; i < jagged.Length; i++){
                for(int j = 0; j < jagged[i].Length; j++){
                    Console.WriteLine("Arreglo en [{0}][{1}]: {2}", i, j, jagged[i][j]);
                }
            }
        }
    }
}