using System;
using Cap8;
using Cap9;

namespace Tarea4
{
    public class Tarea4 {
        public static int option;
        public static int num;
         public static void Menu() {

            do{
                Console.Clear();
                Console.WriteLine("\t..:MENU TAREA 4:..");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Ejercicio 8.3 Hora y fecha actual");
                Console.WriteLine("2. Ejercicio 8.5 Cadenas en orden");
                Console.WriteLine("3. Ejercicio 9.1 Inventario");
                Console.WriteLine("4. Ejercicio 9.3 Dueños y mascotas");
                Console.WriteLine("5. Ejercicio 9.4 Neumáticos");
                
                Console.Write("Opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch(option){
                    case 0: return;
                    case 1: 
                        Eje8_3.HoraYFechaActual();
                        break;
                    case 2:
                        Eje8_5.OrdenarCadenas();
                        break;
                    case 3: 
                        Eje9_1.Inventario();
                        break;
                    case 4:
                        Eje9_3.DueñoYMascota();
                        break;
                    case 5:
                        Eje9_4.Neumaticos();
                        break;
                }

                Console.ReadKey(true);

            }while(option != 0);
        }
    
    }
}