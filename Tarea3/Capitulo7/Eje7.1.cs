using System;
using System.Collections;

namespace Cap7
{
    public class Eje7_1 {
        private static int max;
        private static int min;
        private static float avg;
        private static ArrayList califications = new ArrayList();
        public static void SalonClases(){
            
            int cal = 0;
            Console.WriteLine("Ingrese tantas calificaciones como desee.\nSi quiere para de ingresar calificaciones, ingrese un \"-1\"");

            while(true){
                Console.Write("Ingrese una calificacion: ");
                cal = Convert.ToInt32(Console.ReadLine());

                if(cal == -1) break;

                califications.Add(cal);
                avg += cal;

                if(califications.Count == 1)
                    max = min = cal;

                if(cal > max) max = cal;
                if(cal < min) min = cal;
            }

            avg /= califications.Count;

            Console.WriteLine("\nMáxima calificación: {0}", max);
            Console.WriteLine("Mínima calificación: {0}", min);
            Console.WriteLine("Calificación promedio: {0}", avg);
        }
    }
}