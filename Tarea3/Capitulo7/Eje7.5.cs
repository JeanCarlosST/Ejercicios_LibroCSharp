using System;
using System.Collections;

namespace Cap7
{
    public class Eje7_5 {
        private static Hashtable contacts = new Hashtable();
        private static string name = "";
        private static string number = "";
        public static void AgendaTelefonica(){
            int option = 0;

            do{
                Console.Clear();
                Console.WriteLine(".......AGENDA DE CONTACTOS.......");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Buscar por nombre");
                Console.WriteLine("2. Agregar nuevo contacto");
                Console.WriteLine("3. Borrar contacto");
                Console.WriteLine("4. Modificar contacto");
                Console.WriteLine("5. Mostrar todos los contactos");

                Console.Write("Opción: ");

                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch(option){
                    case 0: return;
                    case 1:
                        Console.Write("Ingrese el nombre del contacto: ");
                        name = Console.ReadLine();
                        number = GetNumber(name);
                        if(number.Equals("none"))
                            Console.WriteLine("Contacto no encontrado");
                        else
                            Console.WriteLine(name + ": " + number);
                        break;
                    case 2:
                        Console.Write("Ingrese el nombre del contacto: ");
                        name = Console.ReadLine();
                        Console.Write("Ingrese el número del contacto: ");
                        number = Console.ReadLine();
                        contacts.Add(name, number);
                        break;
                    case 3:
                        Console.Write("Ingrese el nombre del contacto: ");
                        name = Console.ReadLine();
                        contacts.Remove(name);
                        break;
                    case 4:
                        Console.Write("Ingrese el nombre del contacto: ");
                        name = Console.ReadLine();
                        ModifyContact(name);
                        break;
                    case 5:
                        PrintContacts();
                        break;
                }

                Console.ReadKey();

            }while(option != 0);
        }

        private static string GetNumber(string name){
            foreach(DictionaryEntry w in contacts){
                if(w.Key.Equals(name))
                    return (string)w.Value;
            }
            return "none";
        }

        private static void ModifyContact(string name){
            number = GetNumber(name);

            if(number.Equals("none")){
                Console.WriteLine("Contacto no encontrado.");
                return;
            }

            Console.WriteLine("Para cambiar el nombre, ingrese \"1\"");
            Console.WriteLine("Para cambiar el número, ingrese \"2\"");

            int option = Convert.ToInt32(Console.ReadLine());

            if(option != 1 && option != 2){
                Console.WriteLine("Opción no válida");
                return;
            }

            string newName = name;
            string newNumber = number;

            if(option == 1){
                Console.Write("Ingrese el nuevo nombre del contacto: ");
                newName = Console.ReadLine();
            } else {
                Console.Write("Ingrese el nuevo número del contacto: ");
                newNumber = Console.ReadLine();
            }

            contacts.Remove(name);
            contacts.Add(newName, newNumber);
        }

        private static void PrintContacts(){
            if(contacts.Count == 0){
                Console.WriteLine("Agenda de contactos vacía");
                return;
            }

            int i = 0;
            foreach(DictionaryEntry c in contacts){
                i++;
                Console.WriteLine(i + ") " + c.Key + ": " + c.Value);
            }
        }
    }
}