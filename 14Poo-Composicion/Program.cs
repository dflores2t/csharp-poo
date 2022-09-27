namespace Composition;

public class Program
{
  static void Main(string[] args)
  {
    //CREAMO AL PROPIETARIO
    CPropietario Ana = new CPropietario("ANA");

    //mostramos la propiedad
    Ana.MostrarPropiedad();
    System.Console.WriteLine("-------------");

    //es sencillo llevar a cabo la composicion. cuando se lleva acabo se debe tener especial cuidado porque si no tenemos una programacion correcto podemos romper el encapsulamiento y reducir la seguridad.
    //agregar la propiedad en cpropietario
    //esto rompe la encapsulacion
    CEdificio? edif = Ana.Propiedad; 
    

    edif.muestra();
    System.Console.WriteLine("------------------");

    //ELIMINAMOS EL OBJETO CPROPIETARIO
    Ana = null;
    GC.Collect(); /// esto no elimina a edif porque aun tiene referencia. en composicion no crear propiedades.

    edif.muestra();


  }
}