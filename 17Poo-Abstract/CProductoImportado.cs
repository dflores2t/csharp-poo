namespace Abstract;

public class CProductoImportado : CProducto
{
  protected double impuesto;

  public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
  : base(pDescripcion, pPrecioCompra)
  {
    impuesto = pImpuesto;
  }

  //nuestra propia version del metodo calcular precio
  public override void CalcularPrecio()
  {
    System.Console.WriteLine("CALCULA PRECIO DE IMPORTADO");
    precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
  }

  public override  void MuestraVenta()
  {
    System.Console.WriteLine("EL GRAN PRODUCTO {0} SE VENDE EN ${1}", descripcion, precioVenta);
  }

}