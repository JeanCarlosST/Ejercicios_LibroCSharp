using System;
using System.Collections;

namespace Cap10
{
    public class Producto
    {
        public int Codigo
        { 
            get
            {
                return Codigo;
            } 
            set
            { 
                if(value <= 0) 
                    Codigo = 0;
                else 
                    Codigo = value;
            }
        }
        public string Nombre { get; set; }
        public int Cantidad 
        { 
            get
            {
                return Cantidad;
            } 
            set
            { 
                if(value <= 0) 
                    Cantidad = 0;
                else 
                Cantidad = value;
            }
        }

        public Producto(int codigo, string nombre, int cantidad)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Cantidad = cantidad;
        }

        public Producto()
        {
            this.Codigo = 0;
            this.Nombre = string.Empty;
            this.Cantidad = 0;
        }

        public override string ToString()
        {
            return Codigo + ", " + Nombre + ", " + Cantidad;
        }
    }
    public class Inventario
    {
        ArrayList productos;

        public Inventario()
        {
            productos = new ArrayList();
        }

        public Producto GetProducto(int codigo)
        {
            foreach(Producto p in productos)
            {
                if(p.Codigo == codigo)
                    return p;
            }

            return null;
        }

        public Producto GetProducto(string nombre)
        {
            foreach(Producto p in productos)
            {
                if(p.Nombre.Contains(nombre, System.StringComparison.OrdinalIgnoreCase))
                    return p;
            }

            return null;
        }

        public void ListarProductos()
        {
            int i = 1;
            foreach(Producto p in productos)
            {
                Console.WriteLine(i + ") " + p);
                i++;
            }
        }

        public bool EliminarProducto(int codigo)
        {
            bool eliminado = false;

            foreach(Producto p in productos)
            {
                if(p.Codigo == codigo)
                {
                    productos.Remove(p);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public bool EliminarProducto(string nombre)
        {
            bool eliminado = false;

            foreach(Producto p in productos)
            {
                if(p.Nombre.Contains(nombre, System.StringComparison.OrdinalIgnoreCase))
                {
                    productos.Remove(p);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public bool Existe(int codigo)
        {
            bool encontrado = false;

            foreach(Producto p in productos)
            {
                if(p.Codigo == codigo)
                {
                    encontrado = true;
                    break;
                }
            }

            return encontrado;
        }

        public bool Existe(string nombre)
        {
            bool encontrado = false;

            foreach(Producto p in productos)
            {
                if(p.Nombre.Equals(nombre))
                {
                    encontrado = true;
                    break;
                }
            }

            return encontrado;
        }

        public bool AgregarProducto(Producto producto)
        {
            if(Existe(producto.Codigo) && Existe(producto.Nombre))
                return false;

            productos.Add(producto);
            return true;
        }

        public void AgregarExistencia(int codigo, int cantidad)
        {
            if(cantidad <= 0)
                return;

            Producto producto = GetProducto(codigo);
            if(producto != null)
            {
                productos.Remove(producto);
                producto.Cantidad += cantidad;
                productos.Add(producto);
            }
        }

        public void AgregarExistencia(string nombre, int cantidad)
        {
            if(cantidad <= 0)
                return;

            Producto producto = GetProducto(nombre);
            if(producto != null)
            {
                productos.Remove(producto);
                producto.Cantidad += cantidad;
                productos.Add(producto);
            }
        }

        public void DisminuirExistencia(int codigo, int cantidad)
        {
            if(cantidad <= 0)
                return;

            Producto producto = GetProducto(codigo);
            if(producto != null)
            {
                productos.Remove(producto);
                producto.Cantidad -= cantidad;
                productos.Add(producto);
            }
        }

        public void DisminuirExistencia(string nombre, int cantidad)
        {
            if(cantidad <= 0)
                return;

            Producto producto = GetProducto(nombre);
            if(producto != null)
            {
                productos.Remove(producto);
                producto.Cantidad -= cantidad;
                productos.Add(producto);
            }
        }
    }
    public class Eje10_1
    {
        public static int option;
        public static int num;
        public static void InventarioMenu()
        {
            Inventario inventario = new Inventario();
            char criterio = ' ';
            int codigo = 0;
            string nombre = string.Empty;
            int cantidad = 0;

            do{
                Console.Clear();
                Console.WriteLine("\t..:Inventario:..");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Aumentar cantidad de producto");
                Console.WriteLine("4. Disminuir cantidad de producto");
                Console.WriteLine("5. Listar todos los productos");
                
                Console.Write("Opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch(option){
                    case 0: return;
                    case 1: 
                        inventario.AgregarProducto(SolicitarDatosProducto());
                        break;

                    case 2:
                        Console.Write("Desea eliminar por codigo (C) o por nombre (N)?");
                        criterio = Console.ReadLine().Trim()[0];

                        if(criterio.Equals('C') || criterio.Equals('c'))
                        {
                            Console.Write("Ingrese el codigo del producto: ");
                            inventario.EliminarProducto(Convert.ToInt32(Console.ReadLine()));
                        }
                        else if(criterio.Equals('N') || criterio.Equals('n'))
                        {
                            Console.Write("Ingrese el nombre del producto: ");
                            inventario.EliminarProducto(Console.ReadLine());
                        }

                        break;
                    case 3: 
                        Console.Write("Desea agregar existencias por codigo (C) o por nombre (N)?");
                        criterio = Console.ReadLine().Trim()[0];

                        if(criterio.Equals('C') || criterio.Equals('c'))
                        {
                            Console.Write("Ingrese el codigo del producto: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                        }
                        else if(criterio.Equals('N') || criterio.Equals('n'))
                        {
                            Console.Write("Ingrese el nombre del producto: ");
                            nombre = Console.ReadLine();
                        }

                        Console.Write("Ingrese la cantidad a agregar: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());

                        if(criterio.Equals('C') || criterio.Equals('c'))
                            inventario.AgregarExistencia(codigo, cantidad);
                        
                        else if(criterio.Equals('N') || criterio.Equals('n'))
                            inventario.AgregarExistencia(nombre, cantidad);

                        break;

                    case 4:
                    Console.Write("Desea disminuir existencias por codigo (C) o por nombre (N)?");
                        criterio = Console.ReadLine().Trim()[0];

                        if(criterio.Equals('C') || criterio.Equals('c'))
                        {
                            Console.Write("Ingrese el codigo del producto: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                        }
                        else if(criterio.Equals('N') || criterio.Equals('n'))
                        {
                            Console.Write("Ingrese el nombre del producto: ");
                            nombre = Console.ReadLine();
                        }

                        Console.Write("Ingrese la cantidad a agregar: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());

                        if(criterio.Equals('C') || criterio.Equals('c'))
                            inventario.DisminuirExistencia(codigo, cantidad);
                        
                        else if(criterio.Equals('N') || criterio.Equals('n'))
                            inventario.DisminuirExistencia(nombre, cantidad);

                        break;
                    case 5:
                        inventario.ListarProductos();
                        break;
                }

                Console.ReadKey(true);

            } while(option != 0);     
        }
        
        private static Producto SolicitarDatosProducto()
        {
            Producto producto = new Producto();

            Console.Write("Ingrese el nombre del producto: ");
            producto.Nombre = Console.ReadLine();

            Console.Write("Ingrese el codigo del producto: ");
            producto.Codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad del producto: ");
            producto.Cantidad = Convert.ToInt32(Console.ReadLine());
            
            return producto;
        }
    }
}