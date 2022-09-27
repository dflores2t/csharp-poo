namespace ClassDeclaration;

public class CCalculadora{
  //esta clase es definida por nosotros
  //declaracion de atributos 
  //accesos => public, private ande protected
  public double a;
  public double b;
  public double r;

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