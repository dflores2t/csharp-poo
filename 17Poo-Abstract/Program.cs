namespace Abstract;

public class Program{
  //clase abstracta y metodos abstratos

  //no podemso instancial clase abstracta directamente
  // CProducto miProducto = new CProducto("Bicicleta",3500); //no se puede crear una intstacia de la interfaz o el tipo abstract

  static void Main(string[] args){
    CProductoImportado miProdImp = new CProductoImportado("MOTOCICLETA", 350000, 0.15);
    CProductoDetenido miProdDet = new CProductoDetenido("TELEVISOR", 15000, 0.15, 0.30);

    miProdImp.CalcularPrecio();
    miProdDet.CalcularPrecio();

    miProdImp.MuestraVenta();
    miProdDet.MuestraVenta();
  }
  
  
}