namespace sobrecarga;

public class Cpersona
{
  private string? _nombre;
  private int _edad;

  public Cpersona()
  {
    System.Console.WriteLine("dentro del costructor");
    System.Console.WriteLine("dame el nombre");
    _nombre = Console.ReadLine();
    System.Console.WriteLine("Dame la edad");
    _edad = Convert.ToInt32(Console.ReadLine());

  }
  public Cpersona(string pName, int pEdad)
  {
    _nombre = pName;
    _edad = pEdad;
  }




  public string Nombre { set => _nombre = value; }
  public int Edad { set => _edad = value; }

  public void muestra()
  {
    System.Console.WriteLine("Nombre: {0}, Edad: {1}", _nombre, _edad);
  }



  //DESTRUCTOR

  ~Cpersona()
  {
    //tampoco lleva acceso ni type: void int string etc
    System.Console.WriteLine("Adios desde {0}", _nombre);
    //limpiamos informacion
    _nombre = "";
    _edad = 0;
  }



}