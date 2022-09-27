namespace polimorfismo;

public   class CPerro : CAnimal{
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
    Console.WriteLine("El perro {0} camina ", nombre);
  }
}