namespace Agregacion;

public class CPropietario{

  private string nombre;

  public CPropietario(string pNombre)
  {
    nombre = pNombre;   
  }

  public void MostrarPropiedad(){
    if(propiedad !=null){
      System.Console.WriteLine("{0} Tiene", nombre);
      propiedad.Muestra();
    }
    else{
      System.Console.WriteLine("{0} aun no tinee propiedades", nombre);
    }
  }
  public void AdicionarPropiedad(CEdificio pEdificio)
  {
    if (pEdificio != null)
    {
      propiedad = pEdificio;
    }
  }

  
}