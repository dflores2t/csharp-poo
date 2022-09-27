namespace polimorfismo;
/// <summary>
/// a partir de una clase,
/// a partir de una clase abstracta
/// a partir de interfaces
/// </summary>
public class Program {

  static void Main(string[] args){
    string? valor;
    int opcion;

    //sin polimorfismo, queda concreto a la clase
    // Console.WriteLine("QUE MASCOTA QUIERES? 1-GATO, 2 REPTIL");
    // valor = Console.ReadLine();
    // opcion = Convert.ToInt32(valor);
    // if(opcion ==1){
    //   CGato miGato = new CGato();
    //   miGato.Nombre = "FUZZY";
    //   miGato.Moverse();
    // }
    // if(opcion ==2){
    //   CReptil miReptil = new CReptil();
    //   miReptil.Nombre = "LIZARDO";
    //   miReptil.Moverse();
    // }

    Console.WriteLine("----------------------");
    //con polimorfismo, el codigo se concentra en el concepto no en la clase
    Console.WriteLine("QUE MASCOTA QUIERES? 1-PERRO, 2-PEZ, 3-AVE");
    valor = Console.ReadLine();
    opcion = Convert.ToInt32(valor);

    //creamos la variable que tendra polimorfismo
    CAnimal miMascota = new CAnimal();

    //basado en la seleccion le damos un comportamiento.
    if(opcion ==1)
      miMascota = new CPerro();
    if(opcion ==2)
      miMascota = new CPez();
    if(opcion ==3)
      miMascota = new CAve();

    Console.WriteLine("DAME EL NOMBRE");
    miMascota.Nombre = Console.ReadLine();
    miMascota.Moverse();

  }
}