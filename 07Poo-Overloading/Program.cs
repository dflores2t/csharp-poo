namespace Overloading;

public class Program {
  static void Main(){
    int rInt = 0;
    double rDoub = 0.0;

    CCalculadora calc = new CCalculadora();

    rInt = calc.Suma(5, 3);
    System.Console.WriteLine("El Resultado es: {0}",rInt);

    rDoub = calc.Suma(10.58, 23.17);
    System.Console.WriteLine("El Resultado es: {0}", rDoub);

    rInt = calc.Suma(5, 3, 2);
    System.Console.WriteLine("El Resultado es: {0}", rInt);
  }
}