namespace AccesoSealed;

public class Program {
   static void Main(string[] args){
    CEmpleado uno = new CEmpleado("SUSANA", 25, "PROGRAMADORA", 150000.30);
    uno.EmpleadoMuestra();
    System.Console.WriteLine("-------------------------------------");
    // uno.PonerDatos("SUSANA", 23, "PROGRAMADORA SENIRO", 180000.70); 
    //el acceso protegido nos puede dar un poco de problema porque rompe la parte de la encapsulacion sobre todo de la clase base. ejemplo
    // uno.Edad = 35;
    //TENDRIAMOS UN PROBLEMA DE ENCAPSULACION POR NO ESTAR PROTEGIO.
    uno.PonerDatos("SUSANA", 15, "PROGRAMADOR SENIOR", 180000.70);
    uno.EmpleadoMuestra();
  }
}
