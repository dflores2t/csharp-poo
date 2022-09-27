namespace constructor;

public class Program {
  static void Main(){
    // Cpersona p1 = new Cpersona(); //la parte derecha es la invocacion del constructor
Cpersona p1 = new Cpersona("DANIEL", 40);
    // p1.Nombre = "juan";
    // p1.Edad = 20;
    p1.muestra();


  }
}