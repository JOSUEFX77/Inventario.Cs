using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================");
        Console.WriteLine(" INVENTARIO DE LA TIENDA TECNOPUNTO");
        Console.WriteLine("==================================");

        // Crear tres productos
        Producto producto1 = CrearProducto(1);
        Producto producto2 = CrearProducto(2);
        Producto producto3 = CrearProducto(3);

        // Mostrar los productos registrados
        Console.WriteLine("\n===== PRODUCTOS REGISTRADOS =====");

        Console.WriteLine("\n--- Producto 1 ---");
        producto1.MostrarInfo();

        Console.WriteLine("\n--- Producto 2 ---");
        producto2.MostrarInfo();

        Console.WriteLine("\n--- Producto 3 ---");
        producto3.MostrarInfo();

        Console.WriteLine("\nPrograma finalizado.");
        Console.ReadKey();
    }

    // Método para registrar un producto
    static Producto CrearProducto(int numero)
    {
        while (true)
        {
            Console.WriteLine("\nRegistrar producto número " + numero);

            Console.Write("Código: ");
            string codigo = Console.ReadLine() ?? "";

            string nombre = LeerNombre();
            decimal precio = LeerPrecio();
            int cantidad = LeerCantidad();

            try
            {
                return new Producto(codigo, nombre, precio, cantidad);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Error: " + error.Message);
                Console.WriteLine("Por favor, vuelva a introducir los datos.");
            }
        }
    }

    // Validar el nombre
    static string LeerNombre()
    {
        while (true)
        {
            Console.Write("Nombre del producto: ");
            string nombre = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                return nombre;
            }

            Console.WriteLine("Error: el nombre no puede estar vacío.");
        }
    }

    // Validar el precio
    static decimal LeerPrecio()
    {
        while (true)
        {
            Console.Write("Precio: ");
            decimal precio;

            if (decimal.TryParse(Console.ReadLine(), out precio) && precio > 0)
            {
                return precio;
            }

            Console.WriteLine("Error: introduzca un precio mayor que cero.");
        }
    }

    // Validar la cantidad
    static int LeerCantidad()
    {
        while (true)
        {
            Console.Write("Cantidad: ");
            int cantidad;

            if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad >= 0)
            {
                return cantidad;
            }

            Console.WriteLine("Error: la cantidad no puede ser negativa.");
        }
    }
}
