using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            int num;

            do{
                Console.Write("Ingrese un número del 1 al 7: ");
                value = Console.ReadLine();

                num = Convert.ToInt32(value);
            }while(num < 1 || num > 7);

            switch(num){
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }

            Console.ReadKey(true);
        }
    }
}
