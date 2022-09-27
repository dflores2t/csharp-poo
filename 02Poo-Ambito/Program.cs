namespace Ambito;

public class Program {
  static void Main(string[] args){
    //estas variables solo se conoces en main
    int a = 5;
    a = a * 5;
    System.Console.WriteLine("a ={0}",a);

    //tratamos de usar directamente el dato de la clase
    //
    // b = 30;
    // System.Console.WriteLine("b={0}",b);

    //instanciamos la clase
    CMiClase objeto = new CMiClase();
    objeto.Muestra();
    objeto.Multiplicar();
    objeto.Muestra();
  }
}