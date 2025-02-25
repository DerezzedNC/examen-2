using System;

public class Producto
    {
        public String Nombre ( get; set; )
        Public int Codigo ( get; set; )
        Public double precio ( get; set; )

        public Producto(string nombre, int codigo, double precio)
        {
            Nombre = nombre
            Codigo = codigo
            Precio = precio


        }
    public override string ToString()
    {
        return $"Nombre: {Nombre}. Codigo{Codigo}. Precio{Precio}";
    }
}
public class Tienda
{
    private Producto _Producto;
    private Tienda _siguiente;


public Tienda()
{
_producto = null;
_siguiente = null;
}

public void Agregarproductos(Producto producto)
{
    if (_Producto == null)
    {
        _producto = producto;
        _siguiente = new Tienda();
        
    }
    else
    {
        _siguiente.AgregarProducto(producto);

    }

}

public void MostrarProducto()
{
    if (_Producto != null)
    {
        Console.WriteLine(_Producto.ToString());
        _siguiente.MostrarProductos();

    }
}

public double CalcularPrecioTotal()
{
    if (_Producto == null)
    {

    }
}







