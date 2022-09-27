namespace PublicoPrivado;

public class Program
{
  static void Main(string[] args)
  {
    //creamos un nuevo objeto

    CCalculadora calculadora = new CCalculadora();
    //accedemos a los atributos para colocar la informacion
    calculadora.a = 5;
    calculadora.b = 3;

    //intento acceder a la variable privado
    // System.Console.WriteLine(calculadora.r); //ccalculadora.r no es accesible debido a su nivel de acceso.

    //mostramos los datos
    calculadora.Muestra();

    //invocamos metodo
    calculadora.Suma();

    //mostramos los cambios

    calculadora.Muestra();

  }
}