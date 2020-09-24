using System;
using System.Collections;

namespace Cap7
{
    public class Eje7_2 {
        private static Hashtable dictionary = new Hashtable();
        private static string word = "";
        private static string meaning = "";
        public static void Diccionario(){
            int option = 0;

            do{
                Console.Clear();
                Console.WriteLine(".......DICCIONARIO.......");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Buscar palabra");
                Console.WriteLine("2. Agregar nueva palabra");
                Console.WriteLine("3. Borrar palabra");

                Console.Write("Opción: ");

                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch(option){
                    case 0: return;
                    case 1:
                        Console.Write("Ingrese la palabra: ");
                        word = Console.ReadLine();
                        meaning = GetMeaning(word);
                        if(meaning.Equals("none"))
                            Console.WriteLine("Esa palabra no existe en el diccionario.");
                        else
                            Console.WriteLine(meaning);
                        break;
                    case 2:
                        Console.Write("Ingrese la palabra: ");
                        word = Console.ReadLine();
                        Console.Write("Ingrese el significado: ");
                        meaning = Console.ReadLine();
                        dictionary.Add(word, meaning);
                        break;
                    case 3:
                        Console.Write("Ingrese la palabra: ");
                        word = Console.ReadLine();
                        dictionary.Remove(word);
                        break;
                }

                Console.ReadKey();

            }while(option != 0);
        }

        private static string GetMeaning(string word){
            foreach(DictionaryEntry w in dictionary){
                if(w.Key.Equals(word))
                    return (string)w.Value;
            }
            return "none";
        }
    }
}