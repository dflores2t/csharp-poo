namespace Composition;

public class CPropietario
{

  private string nombre;
  private CEdificio? propiedad = null;

  public CPropietario(string pNombre)
  {
    nombre = pNombre;
    propiedad = new CEdificio("av 2 numero 32", 7, 4); //dentro del consturctor se instacia un objeto que queda asignado a propiedad-> es importante porque aca queda la composicion. esta siendo credo en el ambito de la clase propietario. si el objeto propietario desaparece tambien desapareco lo demas.
  }

  public void MostrarPropiedad()
  {
    if (propiedad != null)
    {
      System.Console.WriteLine("{0} Tiene", nombre);
      propiedad.muestra();
    }
    else
    {
      System.Console.WriteLine("{0} aun no tinee propiedades", nombre);
    }
  }

  //creando una propiedad para el atributo propiedad
  //esto es el peligro de crear la propiedad el exterior puede acceder directamente  a propiedad sin que propietario sepa que sucede y se rompe el encapsulamiento.
  public CEdificio? Propiedad { get => propiedad; set => propiedad = value; }


}