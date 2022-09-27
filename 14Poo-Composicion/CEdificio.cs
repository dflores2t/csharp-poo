namespace Composition;

public class CEdificio{
  private string direccion;
  private int CantDepartametos;
  private int DepRentados;

  public CEdificio(string pDireccion, int pCantidad,int pRentados)
  {
    direccion = pDireccion;
    CantDepartametos = pCantidad;
    DepRentados = pRentados;
  }

  public void muestra(){
    System.Console.WriteLine("Edificio en {0} con {1} departamento, {2}rentados",direccion, CantDepartametos,DepRentados);
  }
}