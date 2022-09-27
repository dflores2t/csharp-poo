namespace MetodosPrivados;

public class Program{
  static void Main(string[] args){
    //creamos un nuevo objeto

    CCalculadora calculadora = new CCalculadora();
    //accedemos a los atributos para colocar la informacion
    calculadora.a = 5;
    calculadora.b = 3;
    //mostramos los datos
    // calculadora.Muestra();
    //no es accesible debido a su nivel de proteccion

    //invocamos metodo
    calculadora.Suma();
  }
}
