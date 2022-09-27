namespace StaticMetods;

public class CCompu
{
  private static double tipoCambio; //sera compartido por todos los objetos de la clase.
  private string procesador = "";
  private int memoria;
  private double costo;

  public CCompu()
  {
    procesador = "i3";
    memoria = 2;
    costo = 350;
  }

  public CCompu(string pProcesador, int pMemoria, double pCosto){
    procesador = pProcesador;
    memoria = pMemoria;
    costo = pCosto;
  }

  public double TipoCambio{
    set { tipoCambio = value; }
  }
  public void MuestraDolares(){
    System.Console.WriteLine("Procesador: {0}, Memoria:{1}",procesador,memoria);
    System.Console.WriteLine("Costo $USD:{0}", costo);
  }
  public void MuestraPesos(){
    System.Console.WriteLine("Procesador: {0}, Memoria:{1}", procesador,memoria);
    System.Console.WriteLine("Costo $:{0}, TC:{1}",costo * tipoCambio, tipoCambio);
  }

}