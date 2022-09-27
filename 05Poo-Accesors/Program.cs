namespace Accesor;

public class Program{
  static void Main()
  {
    double Impuesto = 0.0;

    //creamos el objeto
    CEmpleado Juan = new CEmpleado();
    //no podemos usar esto
    //Juan.suelo =1000;

    Juan.set_sueldo(15000);
    Juan.muestra();
    Juan.CalculaImpuesto();
    Impuesto = Juan.get_impuesto();
    System.Console.WriteLine("El impuesto es {0}", Impuesto);

    System.Console.WriteLine("-----SEGUNAD PARTE ACCESSOR");
    Juan.set_sueldo(7800);
    Juan.CalculaImpuesto();
    Juan.muestra();
    Juan.MuesraLog();

    System.Console.WriteLine("---------------------------------");
    CEmpleado Jose = new CEmpleado();
    Jose.set_sueldo(50000);
    Jose.set_sueldo(2500);
    Jose.set_sueldo(10000);
    System.Console.WriteLine("El Sueldo de jose  es {0}", Jose.get_sueldo(56));
    Jose.muestra();
    Jose.MuesraLog();
  }
}