namespace newmethod;

public class Program{
  static void Main(string[] args){
    //uso de new en metodos
    //nos permite poner codigo propio a metodos no virtuales
    //pero perdemos polimorfismo
    //cuando se desea modificar un metodo de una clase y esta no tiene virtual. o cuando notenemos acceso al codigo

    CProductoImportado miProducto = new CProductoImportado("MOTOCICLETA", 450000,0.15);

    miProducto.CalcularPrecio();
    miProducto.MuestraVenta();
    System.Console.WriteLine("---------------------------------");
    CProducto p1 = new CProducto("TELEVISION", 10500);

    p1.CalcularPrecio();
    p1.MuestraVenta();

    System.Console.WriteLine("-----------perdida de polimorfismo-----------------------");
    CProducto p3 = new CProductoImportado("BICICLETA", 2200, 0.2); //POLIMORFISMO CON P3
    p3.CalcularPrecio();
    p3.MuestraVenta(); //ESTE AL TENER NEW EN EL METODO MUESTRA VENTA, PIERDE SU CARACTERISTICA POLIMORFICA. Y MANDA LA VERSION DE LA BASE.


  }
}
