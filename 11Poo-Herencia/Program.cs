namespace Herencia;

public class Program{
  static void Main(string[] args){

    //creamos objeto de la clase persona
    // CPersona uno = new CPersona();
    // uno.Nombre = "MARIA";
    // uno.Edad = 27;

    // uno.Muestra();


    // //creamos un objeto de la clase Empleado
    // CEmpleado dos = new CEmpleado();

    // dos.Nombre = "JUAN";
    // dos.Edad = 30;

    // dos.Puesto = "Contador";
    // dos.Salario = 10500.50;

    // //usamos el muestra de empleado
    // dos.EmpleadoMuestra();

    // //verificamos que podemo usar el muestra de la clas base
    // dos.Muestra();

    // CEmpleado tres = new CEmpleado();

    // tres.PonerDatos("SUSANA", 25, "PRGROMADORA", 15000.30);
    // tres.EmpleadoMuestra();


    System.Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    System.Console.WriteLine("-----------------CONSTRUCTUR HERENCIA-------------------------");
    System.Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    CPersona uno = new CPersona("Maria", 27);
    uno.Muestra();
    System.Console.WriteLine("-------------------------");

    //creamos un objeto de la clase empleado
    CEmpleado dos = new CEmpleado("Juan",30,"Contador",10500.50);

    //usamos el muestra de empleado
    dos.EmpleadoMuestra();

    //creamos otro empleado
    CEmpleado tres = new CEmpleado("Susana", 25, "Programadora", 150000.30);
    tres.EmpleadoMuestra();
    System.Console.WriteLine("---------------------------------------------");
    tres.PonerDatos("Susana", 23, "Programadora Senior", 180000.70);
    tres.EmpleadoMuestra();

  }
}