namespace ClassDeclaration;

public class Program{
  static void Main(string[] args){
    //creamos la instancia
    //es la forma para crear un nuevo objeto.
    CCalculadora calc = new CCalculadora();

    //accedemos a los atributos para colocar informacion
    calc.a = 5;
    calc.b = 3;

    //mostramos los datos
    calc.Muestra();

    //invocamos metodo
    calc.Suma();

    //mostramos nueamente los datos
    calc.Muestra();


    //otro objeto
    //cada objeto se crea por separado y cada objeto tiene sus propios atributos
    CCalculadora calc2 = new CCalculadora();
    calc2.a = 25;
    calc2.b = 25;
    calc2.Muestra();
    calc2.Suma();
    calc2.Muestra();
  }
}