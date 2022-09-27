namespace Agregacion;

public class Program{
  static void Main(string[] args){
    //EJEMPLO DE AGREGACION
    //CREAMON AL PROPIETARIO
    CPropietario Juan = new CPropietario("Juan");

    // CREAMOS LA PROPIEDAD
    CEdificio edif1 = new CEdificio("Av. 1 num 56", 10, 3);
    //vemos info del propietario
    //aunque los objetos existen aun no llevamso a cabo la agregacion.
    Juan.MostrarPropiedad();
    //le colocamos la propiedad
    Juan.AdicionarPropiedad(edif1);
    Juan.MostrarPropiedad();

    //en la agregacion los objetos tienen vida por separado.
    Juan = null;
    GC.Collect(); //c# es administrado, no podemos destruir el objeto. tratamos de simularlo
    // Juan.MostrarPropiedad();
    System.Console.WriteLine("---------------------------------");
    //VERIFICAMOS QUE EL EDIFICIO EXISTA INDEPENDIENTEMENTE DE JUAN
    edif1.muestra();
  }
}
