namespace PublicoPrivado;

public class CCalculadora{
  //los atributos al tener el acceso de tipo publico cualquiero puede acceder a estas variables y cambiar los datos, se rompe la seguridada y el encapsulamiento de la poo
  
  public double a;
  public double b;
  //tipo private
  private double r; //solo el interior del objeto puede trabajar con el

  //los atributos jamas deben ser publicos dentro de una clase, porque se rompel el encapsulamiento.
  //para eso estan los accesor.
  //este ejemplo es con fines demostrativos
  //public el exterior tiene acceso a el

  //declaracion de metodos
  //pueden ser publicos o privados hay que pensar bien como seran declarados
  public void Suma(){
    //se lleva a cabo una accion
    r = a + b;
  }

  public void Muestra(){
    System.Console.WriteLine("a={0}, b={1}, r={2} ", a,b,r);
  }

}