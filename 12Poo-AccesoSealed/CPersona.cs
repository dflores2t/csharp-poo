namespace AccesoSealed;

public class CPersona
{
  protected string _nombre;
  protected  int _edad;

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
      if (value >= 18)
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