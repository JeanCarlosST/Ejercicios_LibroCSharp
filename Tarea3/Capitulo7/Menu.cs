using System;
using Cap6;
using Cap7;

namespace Tarea3
{
    public class Tarea3 {
        public static int option;
        public static int num;
         public static void Menu() {

            do{
                Console.Clear();
                Console.WriteLine("\t..:MENU TAREA 3:..");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Ejercicio 6.1 Promedio con arreglo jagged");
                Console.WriteLine("2. Ejercicio 6.2 Cal. mínima con arreglo jagged");
                Console.WriteLine("3. Ejercicio 6.3 Cal. máxima con arreglo jagged");
                Console.WriteLine("4. Ejercicio 6.4 Programa de escuela con funciones");
                Console.WriteLine("5. Ejercicio 6.5 Arreglo jagged como parametro");
                Console.WriteLine("6. Ejercicio 7.1 Salón de clases");
                Console.WriteLine("7. Ejercicio 7.2 Diccionario");
                Console.WriteLine("8. Ejercicio 7.5 Agenda telefónica");
                
                Console.Write("Opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch(option){
                    case 0: return;
                    case 1: 
                        Eje6_1.PromedioJagged();
                        break;
                    case 2:
                        Eje6_2.MinimaJagged();
                        break;
                    case 3: 
                        Eje6_3.MaximaJagged();
                        break;
                    case 4:
                        Eje6_4.JaggedWithFunctions();
                        break;
                    case 5:
                        Eje6_5.JaggedParameter();
                        break;
                    case 6:
                        Eje7_1.SalonClases();
                        break;
                    case 7:
                        Eje7_2.Diccionario();
                        break;
                    case 8:
                        Eje7_5.AgendaTelefonica();
                        break;
                }

                Console.ReadKey(true);

            }while(option != 0);
        }
    
    }
}