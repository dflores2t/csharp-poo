namespace newmethod;

public class CProducto
{

  protected string descripcion;
  protected double precioCompra;
  protected double precioVenta;

  public CProducto(string pDescripcion, double pPrecioCompra)
  {
    descripcion = pDescripcion;
    precioCompra = pPrecioCompra;
    precioVenta = 0.0;
  }

  public virtual void CalcularPrecio()
  {
    System.Console.WriteLine("Calcula precio de producto ");
    precioVenta = precioCompra * 1.3;
  }

  public void MuestraVenta()
  {
    System.Console.WriteLine("{0} se vende {1} ", descripcion, precioVenta);
  }

}