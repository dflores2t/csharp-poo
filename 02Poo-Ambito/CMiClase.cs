namespace Ambito;

public class CMiClase
{
  //los datos a continuacion pueden verse en cualquier lugar de la clase , pero no fuera de ella, => AMBITO DE OBJETO
  private int b = 10;

  //metodo
  public void Muestra()
  {
    //creamos una variable local a muestra
    // AMBITO LOCAL
    int m = 5;

    //podemos usar la variable local
    System.Console.WriteLine("m={0}", m);

    //tratamos de mostrar la variable de main
    // System.Console.WriteLine("a={0} ", a);

    //tratamos de mostrar el dato de la clase
    System.Console.WriteLine("b={0}", b);
  }

  public void Multiplicar(){
    int m = 7; //puedo tener variables con el mismo nombre si el ambito es local.
    //tratamos de usar el dato de la clase
    b = b * 5;

    //tratamos de usar la variable laocal del metodo muestra
     m = m * 100; //manda error
  }


}