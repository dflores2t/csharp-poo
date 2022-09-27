namespace polimorfismo;

public class CAve:CAnimal{
  // private string nombre;

  // public string Nombre
  // {
  //   get
  //   {
  //     return nombre;
  //   }
  //   set
  //   {
  //     nombre = value;
  //   }
  // }

  public override void Moverse()
  {
    Console.WriteLine("El ave {0} wuera ", nombre);
  }
}