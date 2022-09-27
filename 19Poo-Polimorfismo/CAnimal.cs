namespace polimorfismo;

public class CAnimal{
  protected string? nombre;

  public string Nombre
  {
    get
    {
      return nombre;
    }
    set
    {
      nombre = value;
    }
  }

  public virtual void Moverse()
  {
    Console.WriteLine("EL ANIMAL SE MUEVE");
  }
}