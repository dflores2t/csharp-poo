namespace FuncionesVirtuales;

public class CProductoImportado :CProducto{
  protected double impuesto;

  public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
  :base (pDescripcion, pPrecioCompra)
  {
    impuesto = pImpuesto;
  }

  //nuestra propia version del metodo calcular precio
  public sealed override void CalcularPrecio(){
    System.Console.WriteLine("CALCULA PRECIO DE IMPORTADO");
    precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
  }

}