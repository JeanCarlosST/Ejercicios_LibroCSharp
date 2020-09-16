using System;

namespace Tarea1 {
    class Tarea1 {
        public static int option;
        public static int num;

        public static void Menu() {
            do{
                Console.Clear();
                Console.WriteLine("\t..:MENU TAREA 1:..");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Ejercicio 1.1 Hola Mundo");
                Console.WriteLine("2. Ejercicio 1.5 Hola++");
                Console.WriteLine("3. Ejercicio 2.1 Perimetro");
                Console.WriteLine("4. Ejercicio 2.3 Grados a radianes");
                Console.WriteLine("5. Ejercicio 2.4 Celsius a Fahrenheit");
                Console.WriteLine("6. Ejercicio 2.5 USD/EUR");
                Console.WriteLine("7. Ejercicio 3.1 Paridad");
                Console.WriteLine("8. Ejercicio 3.4 Dias de la semana");
                Console.Write("Opcion: ");

                option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                switch(option){
                    case 0: return;
                    case 1: 
                        Eje1_1.HelloYou();
                        break;
                    case 2:
                        Eje1_5.HelloPlus();
                        break;
                    case 3: 
                        Eje2_1.Perimetro();
                        break;
                    case 4:
                        Eje2_3.Gradios_Radianes();
                        break;
                    case 5:
                        Eje2_4.Celsius_Fahrenheit();
                        break;
                    case 6:
                        Eje2_5.Dolar_Euro();
                        break;
                    case 7:
                        Eje3_1.Paridad();
                        break;
                    case 8:
                        Eje3_4.Dias();
                        break;
                }

                Console.ReadKey(true);

            }while(option != 0);
        }
    }
}
