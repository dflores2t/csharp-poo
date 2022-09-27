namespace Properties;

public class Program{
  static void Main(){
    //creamos el objeto
    CEmpleado Juan = new CEmpleado();
    Juan.Sueldo = 15000;
    Juan.CalculaImpuesto();

    System.Console.WriteLine("El Impuesto de Juan es :{0}",Juan.Impuesto);

    Juan.Muestra();
  } 
}