namespace FuncionesVirtuales;

public class Program{
  static void Main(string[] args){
    //creamon producto

    CProducto uno = new CProducto("bicicleta", 2500.35);
    uno.CalcularPrecio();
    uno.MuestraVenta();
    System.Console.WriteLine("---------------------------");

    //CREAMOS PRODUCTO IMPORTAD
    CProductoImportado dos = new CProductoImportado("bicicleta importada", 2500.35, 0.15);
    dos.CalcularPrecio();
    dos.MuestraVenta();
    System.Console.WriteLine("----------------------");

    // creamos producto con multa

    CProductoDetenido tres = new CProductoDetenido("bici detenida", 2500.35, 0.15, 500.8);
    tres.CalcularPrecio();
    tres.MuestraVenta();
    
  }
}