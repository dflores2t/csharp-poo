namespace polimorfismo;

public class CPez :CAnimal{
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
    Console.WriteLine("El pez {0} nada ", nombre);
  }
}