namespace sobrecarga;
public class Program{
  static void Main(){
    Cpersona per1 = new Cpersona();
    Cpersona per2 = new Cpersona("daniel", 27);

    per1.muestra();
    per2.muestra();
  }
}