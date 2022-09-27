namespace polimorfismo;
public class CGato:CAnimal{
  // private string nombre;

  // public string Nombre {
  //   get {
  //     return nombre;
  //   }
  //   set{
  //     nombre = value;
  //   }
  // }

  public override void Moverse(){
    Console.WriteLine("El gato {0} camina ", nombre);
  }
}