namespace Herencia;

public class CPersona
{
  private string _nombre;
  private  int _edad;

  //CONSTRUCTORES EN HERENCIA
  public CPersona(string pNombre , int pEdad)
  {
    System.Console.WriteLine("CONSTRUCTURO DE CPERSONA");
    _nombre = pNombre;
    _edad = pEdad;
  }


  public string Nombre { get => _nombre; set => _nombre = value; }
  public int Edad
  {
    get => _edad;
    set
    {
      if (Edad >= 18)
        _edad = value;
      else
      {
        _edad = -1;
        System.Console.WriteLine("Edad No Permitida");
      }


    }
  }

  public void Muestra() { 
    System.Console.WriteLine("{0} tiene {1} ",_nombre,_edad);
  }

}