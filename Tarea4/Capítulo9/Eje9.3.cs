using System;
using System.Collections;

namespace Cap9
{
    public struct Mascota
    {
        string nombre;
        string especie;
        Dueño dueño;

        public Mascota(string nombre, string especie, Dueño dueño)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.dueño = dueño;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre +
                    "\nEspecie: " + especie;
        }
    }

    public struct Dueño
    {
        string nombre;
        string telefono;

        public Dueño(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre +
                   "\nTeléfono: " + telefono;
        }
    }
    public class Eje9_3 {
        public static void DueñoYMascota()
        {
            string nombreDueño;
            string telefono;
            string nombreMascota;
            string especieMascota;

            Console.Write("Ingrese el nombre del dueño: ");
            nombreDueño = Console.ReadLine();
            
            Console.Write("Ingrese el teléfono del dueño: ");
            telefono = Console.ReadLine();

            Console.Write("Ingrese el nombre de la mascota: ");
            nombreMascota = Console.ReadLine();

            Console.Write("Ingrese la especie de la mascota: ");
            especieMascota = Console.ReadLine();

            Dueño dueño = new Dueño(nombreDueño, telefono);
            Mascota mascota = new Mascota(nombreMascota, especieMascota, dueño);

            Console.WriteLine("\nDueño:\n" + dueño);
            Console.WriteLine("Mascota:\n" + mascota);
        }
    }
}