namespace Abstract;

public class CProductoDetenido : CProducto{
  private double multa;
  private double impuesto;

  public CProductoDetenido(string pDescripcion, double pPrecioCompa, double pImpuesto, double pMulta)
  : base (pDescripcion, pPrecioCompa)
  {
    multa = pMulta;
    impuesto = pImpuesto;
  }

  public override void CalcularPrecio()
  {
    System.Console.WriteLine("CALCULA PRECIO DE IMPORTADO CON MULTA");
    precioVenta = ((precioCompra * (1 + impuesto)) * 1.30) + multa;
  }

  public override void MuestraVenta()
  {
    Console.WriteLine("EL PRODUCTO EN ADUANA {0} TIENE UN COSTO DE {1}", descripcion,precioVenta);
  }
}