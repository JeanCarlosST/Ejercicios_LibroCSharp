using System;
using Cap10;
using Cap12;

namespace Tarea5
{
    public class Tarea5 {
        public static int option;
        public static int num;
         public static void Menu() {

            do{
                Console.Clear();
                Console.WriteLine("\t..:MENU TAREA 5:..");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Ejercicio 10.1 Inventario");
                Console.WriteLine("2. Ejercicio 10.2 Escuela");
                Console.WriteLine("3. Ejercicio 12.1 Depuración de factorial");
                Console.WriteLine("4. Ejercicio 12.2 Depuración de factorial por consola");
                
                Console.Write("Opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch(option){
                    case 0: return;
                    case 1: 
                        Eje10_1.InventarioMenu();
                        break;
                    case 2:
                        Eje10_2.Escuela();
                        break;
                    case 3:
                        Eje12_1.Factorial();
                        break;
                    case 4:
                        Eje12_2.Factorial();
                        break;
                }

                Console.ReadKey(true);

            }while(option != 0);
        }
    
    }
}