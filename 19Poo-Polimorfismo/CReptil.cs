namespace polimorfismo;

public class CReptil :CAnimal{
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
    Console.WriteLine("El reptil {0} se arrastra ", nombre);
  }
}