using System;

public class Producto
{
    private string _nombre = "";
    private decimal _precio;
    private int _cantidad;

    public string Codigo { get; set; }

    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");
            _nombre = value;
        }
    }

    public decimal Precio
    {
        get { return _precio; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");
            _precio = value;
        }
    }

    public int Cantidad
    {
        get { return _cantidad; }
        set
        {
            if (value < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.");
            _cantidad = value;
        }
    }

    public decimal ValorTotal
    {
        get { return Precio * Cantidad; }
    }

    public Producto(string codigo, string nombre, decimal precio, int cantidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public void MostrarInfo()
    {
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Precio: " + Precio.ToString("C2"));
        Console.WriteLine("Cantidad: " + Cantidad);
        Console.WriteLine("Valor total: " + ValorTotal.ToString("C2"));
    }
}
