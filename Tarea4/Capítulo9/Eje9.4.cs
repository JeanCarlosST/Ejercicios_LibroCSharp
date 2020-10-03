using System;
using System.Collections;

namespace Cap9
{
    public enum Neumatico{ Diagonal, Radial, Invierno, Verano, 
                    AllSeasons, Asimetrico, Simetrico, Tubeless, 
                    BajoPerfil, Recauchutados, Runflat, Ecologicos}
    public class Eje9_4 {

        public static void Neumaticos()
        {
            Neumatico neumatico;

            Console.WriteLine("Tipos de neumáticos");

            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine("Nombre: {0}, valor: {1}", (Neumatico)i, i);
            }

            Console.Write("Seleccione el tipo de neumático que desee: ");

            neumatico = (Neumatico)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El neumático seleccionado fue {0}", neumatico);
        }
    }
}