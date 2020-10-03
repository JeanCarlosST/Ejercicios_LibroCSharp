using System;
using System.Collections;

namespace Cap9
{
    public struct Producto
    {
        public string nombre;
        public string descripcion;
        public int cantidad;
        public float precio;

        public Producto(string nombre, string descripcion, int cantidad, float precio)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + 
                    "\nDescripción: " + descripcion + 
                    "\nCantidad: " + cantidad +
                    "\nPrecio: " + precio;
        }
    }

    public class Eje9_1 
    {
        public static int option;
        public static int num;

        public static string nombre;
        public static string desc;
        public static int cantidad;
        public static float precio;
        public static Producto prod;

        public static void Inventario()
        {
            ArrayList Productos = new ArrayList();

            do{
                Console.Clear();
                Console.WriteLine("\t..:Inventario:..");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Crear nuevo producto");
                Console.WriteLine("2. Buscar producto");
                Console.WriteLine("3. Eliminar producto");
                Console.WriteLine("4. Listar todos los productos");
                
                Console.Write("Opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch(option){
                    case 0: return;
                    case 1: 
                        Console.WriteLine("Nuevo producto\n");
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Descripción: ");
                        desc = Console.ReadLine();
                        Console.Write("Cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Precio: ");
                        precio = Convert.ToSingle(Console.ReadLine());

                        Productos.Add(new Producto(nombre, desc, cantidad, precio));
                        break;
                    case 2:
                        Console.WriteLine("Buscar producto\n");
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        prod = Buscar(nombre, Productos);

                        if(prod.nombre.Equals("-1"))
                        {
                            Console.WriteLine("Producto inexistente");
                            break;
                        }

                        Console.WriteLine(prod);
                        break;
                    case 3:
                        Console.WriteLine("Borrar producto\n");
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        prod = Buscar(nombre, Productos);

                        if(prod.nombre.Equals("-1"))
                        {
                            Console.WriteLine("Producto inexistente");
                            break;
                        }

                        Productos.Remove(prod);
                        Console.WriteLine("Producto eliminado");
                        break;
                    
                    case 4:
                        Console.WriteLine("Listar todos los productos\n");
                        int i = 1;
                        foreach(Producto p in Productos)
                        {
                            Console.WriteLine(i + ")\n" + p);
                        }

                        break;
                }

                Console.ReadKey(true);

            }while(option != 0);
        }

        private static Producto Buscar(string nombre, ArrayList Productos)
        {
            foreach(Producto p in Productos)
            {
                if(p.nombre.Equals(nombre))
                    return p;
            }

            return new Producto("-1", "", 0, 0);
        }

    }
}