namespace FuncionesVirtuales;

public class CProductoDetenido : CProductoImportado{
  private double multa;

  public CProductoDetenido(string pDescripcion, double pPrecioCompa, double pImpuesto, double pMulta)
  : base (pDescripcion, pPrecioCompa, pImpuesto)
  {
    multa = pMulta;
  }

  // public override void CalcularPrecio()
  // {
  //   System.Console.WriteLine("CALCULA PRECIO DE IMPORTADO CON MULTA");
  //   precioVenta = ((precioCompra * (1 + impuesto)) * 1.30) + multa;
  // }
}