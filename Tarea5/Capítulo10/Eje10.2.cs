using System;
using System.Collections;

namespace Cap10
{
    public class Estudiante
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string GradoCurso { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Estudiante()
        {
            this.Nombres = string.Empty;
            this.Apellidos = string.Empty;
            this.GradoCurso = string.Empty;
            this.FechaNacimiento = DateTime.Now;
        }

        public override string ToString()
        {
            return Apellidos + ", " + Nombres + ", " + GradoCurso + ", " + FechaNacimiento.ToShortDateString();
        }
    }

    public class Escuela
    {
        ArrayList estudiantes;

        public Escuela()
        {
            estudiantes = new ArrayList();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

        public void EliminarEstudiante(Estudiante estudiante)
        {
            estudiantes.Remove(estudiante);
        }

        public Estudiante BuscarEstudiante(string nombre, string apellidos)
        {
            foreach(Estudiante e in estudiantes)
            {
                if(e.Nombres.Equals(nombre) && e.Apellidos.Equals(apellidos))
                    return e;
            }

            return null;
        }
        public void ListarEstudiantes()
        {
            int i = 1;
            foreach(Estudiante e in estudiantes)
            {
                Console.WriteLine(i + ") " + e);
                i++;
            }
        }

        public void ListarEstudiantes(string curso)
        {
            int i = 1;
            foreach(Estudiante e in estudiantes)
            {
                if(e.GradoCurso.Equals(curso))
                {
                    Console.WriteLine(i + ") " + e);
                    i++;
                }
            }
        }
    }

    public class Eje10_2
    {
        public static int option;
        public static int num;
        public static void Escuela()
        {
            Escuela escuela = new Escuela();

            do{
                Console.Clear();
                Console.WriteLine("\t..:Escuela:..");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Agregar nuevo estudiante");
                Console.WriteLine("2. Eliminar estudiante");
                Console.WriteLine("3. Listar estudiante por curso");
                Console.WriteLine("4. Listar todos los estudiantes");
                
                Console.Write("Opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch(option){
                    case 0: return;
                    case 1: 
                        escuela.AgregarEstudiante(SolicitarDatosEstudiante());
                        break;
                    case 2:
                        string nombre = "";
                        string apellido = "";

                        Console.Write("Ingrese el nombre del estudiante: ");
                        nombre = Console.ReadLine();

                        Console.Write("Ingrese el apellido del estudiante: ");
                        apellido = Console.ReadLine();

                        escuela.EliminarEstudiante(escuela.BuscarEstudiante(nombre, apellido));
                        break;
                    case 3: 
                        Console.Write("Ingrese el curso: ");
                        escuela.ListarEstudiantes(Console.ReadLine());
                        break;
                    case 4:
                        escuela.ListarEstudiantes();
                        break;
                }

                Console.ReadKey(true);

            }while(option != 0);
        }

        private static Estudiante SolicitarDatosEstudiante()
        {
            Estudiante estudiante = new Estudiante();

            Console.Write("Ingrese el nombre del estudiante: ");
            estudiante.Nombres = Console.ReadLine();

            Console.Write("Ingrese el apellido del estudiante: ");
            estudiante.Apellidos = Console.ReadLine();

            Console.Write("Ingrese el curso del estudiante: ");
            estudiante.GradoCurso = Console.ReadLine();

            Console.Write("Ingrese la fecha de nacimiento del estudiante: ");
            estudiante.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            return estudiante;
        }
    }
}