namespace StaticMetods;

public class Program
{
  static void Main(string[] args)
  {
    double r = 0.0;
    // CCompu compu1 = new CCompu();
    // CCompu compu2 = new CCompu("i5", 4, 450);
    // CCompu compu3 = new CCompu("i7", 8, 670);

    // compu1.TipoCambio = 15.70;

    // //mostramso
    // compu1.MuestraDolares();
    // compu1.MuestraPesos();
    // System.Console.WriteLine("------------");

    // compu2.MuestraDolares();
    // compu2.MuestraPesos();
    // System.Console.WriteLine("--------------");

    // compu3.MuestraDolares();
    // compu3.MuestraPesos();
    // System.Console.WriteLine("----------------");

    // //HACEMOS EL CAMBIO, DEBE REFLEJARSE EN TODOS LOS OBJETOS
    // compu3.TipoCambio = 18.80;
    // //mostramso
    // compu1.MuestraDolares();
    // compu1.MuestraPesos();
    // System.Console.WriteLine("------------");

    // compu2.MuestraDolares();
    // compu2.MuestraPesos();
    // System.Console.WriteLine("--------------");

    // compu3.MuestraDolares();
    // compu3.MuestraPesos();
    // System.Console.WriteLine("----------------");

    //=========================MEDOTOD STATICOS==========================

    //clase normal
    CCalculadora miCalcu = new CCalculadora(5, 3);
    miCalcu.Suma();
    System.Console.WriteLine("La suma es : {0}", miCalcu.R);
    miCalcu.resta();
    System.Console.WriteLine("La resta es: {0}", miCalcu.R);

    //Clase con metodo estatico
    r = CCalculadoraS.Suma(6, 9);
    System.Console.WriteLine("La suma es : {0}",r );
    r = CCalculadoraS.Resta(45, 67);
    System.Console.WriteLine("La resta es: {0}",r);


  }
}