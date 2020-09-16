using System;

namespace Tarea2
{
    class Tarea2 {
        public static int option;
        public static int num;

        public static void Menu() {
            do{
                Console.Clear();
                Console.WriteLine("\t..:MENU TAREA 2:..");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Ejercicio 4.1 Tabla de multiplicación");
                Console.WriteLine("2. Ejercicio 4.2 Potencia");
                Console.WriteLine("3. Ejercicio 4.5 Promedio");
                Console.WriteLine("4. Ejercicio 5.4 Factorial");
                Console.WriteLine("5. Ejercicio 5.5 Numero escrito");
                Console.Write("Opcion: ");

                option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                switch(option){
                    case 0: return;
                    case 1: 
                        Console.Write("Ingrese un número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Eje4_1.Multiplos(num);
                        break;
                    case 2:
                        Console.Write("Ingrese el número de base: ");
                        int base_ = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese la potencia: ");
                        int pow = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado: " + Eje4_2.Potencia(base_,pow));
                        break;
                    case 3: 
                        Eje4_5.Promedio();
                        break;
                    case 4:
                        Console.Write("Ingrese un número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado: " + Eje5_4.Factorial(num));
                        break;
                    case 5:
                        Console.Write("Ingrese un número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado: " + Eje5_5.Numeros(num));
                        break;
                }

                Console.ReadKey(true);

            }while(option != 0);
        }
    }
}
