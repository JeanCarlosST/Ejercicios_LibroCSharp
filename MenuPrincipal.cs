using System;

namespace Ejercicios_LibroCSharp
{
    class MenuPrincipal {
        public static int option = 0;
        static void Main(string[] args) {
            do{
                Console.Clear();
                Console.WriteLine("\t..:MENU PRINCIPAL:..");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Tarea 1");
                Console.WriteLine("2. Tarea 2");
                Console.WriteLine("3. Tarea 3");
                Console.WriteLine("4. Tarea 4");
                Console.WriteLine("5. Tarea 5");
                Console.Write("Opcion: ");

                option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                switch(option){
                    case 0: break;
                    case 1:
                        Tarea1.Tarea1.Menu();
                        break;
                    case 2:
                        Tarea2.Tarea2.Menu();
                        break;
                    case 3:
                        Tarea3.Tarea3.Menu();
                        break;
                    case 4:
                        Tarea4.Tarea4.Menu();
                        break;
                    case 5:
                        Tarea5.Tarea5.Menu();
                        break;
                }

                Console.ReadKey(true);
                
            }while(option != 0);

            Console.Clear();
        }
    }
}
