namespace Casting;

public class Program
{
  static void Main(string[] args){
    //PODEMOS HACRE CASTING DE UNA CLASE
    //CProductoImportado es un CProducto
    CProducto p1 = new CProductoImportado("TELE", 2500, 0.15);

    p1.CalcularPrecio();
    Console.WriteLine(p1);

    //no puede invocar lo que no es comun
    // p1.mensaje();
    //p1 aunque es cproducto no sabe nade del metodo de producto importado, solo lo que es comun en ellos

    ((CProductoImportado)p1).Mensaje(); //typecaste actuara com cproducto importado en esta linea.

    Console.WriteLine("-------------------------");
    //cproducto es un object
    object p2 = new CProducto("RADIO", 300); // object es el supertipo, cualquier otra clase que defina desciende de el

    ((CProducto)p2).CalcularPrecio();
    Console.WriteLine(((CProducto)p2)); //si no se hace typcast se toma como p2 cproducto

    Console.WriteLine("----------------------------");

    //oject no es un cproducto
    // CProducto p3 = new object(); //esto no se debe hacer ni se puede

    Console.WriteLine("-------------DETECTA------------");
    CProducto p4 = new CProducto("Balon", 250.50);

    Detecta(p1);
    Detecta((CProducto)p2);
    Detecta(p4);
    Console.WriteLine("-----------------------------------");

    //CASTING NUMERICOS.
    //los tipos menores alcanzan en un tipo mayores sin necesidod de hacer casting
    //si es al contrario se tendria que hacer un casting
    int a = 57;
    float b = 5.67f;
    double c = 123.456;
    byte  x = 5;
    //de un tipo menor a uno mayor no hace falta poner explicitamente el castig
    a = x;
    Console.WriteLine(a);

    double y = b;
    Console.WriteLine(y);

    //de un tipo mayor a un menor
    // b = c; //error no se puede converti implicitamente el tipo double a flat
    b = (float)c;
    Console.WriteLine(b);

    //OJO EL CAST DE UNO MAYOR A UNO MENOR OCASIONA PERDIDA DE INFORMACION.


  }


  public static void Detecta(CProducto pProducto){
    if(pProducto is CProducto) // is: si determinada instancia pertenece o puede ser utilizada com tal clase true/false
    {
      Console.WriteLine("===Es CProducto");
      pProducto.CalcularPrecio();
      Console.WriteLine(pProducto);
    }
    if(pProducto is CProductoImportado){
      Console.WriteLine("== Es CProductoImportado");
      pProducto.CalcularPrecio();
      ((CProductoImportado)pProducto).Mensaje();
      Console.WriteLine(pProducto);
    }
  }
}