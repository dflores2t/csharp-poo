namespace Accesor;

public class CEmpleado{

  //attributes
  private double _sueldo;
  private double _impuesto;
  private string log;

  public void muestra(){
    System.Console.WriteLine("Sueldo={0}, Impuesto={1}",_sueldo,_impuesto);
  }

  //ACCESOR - GET -SET
  public double get_sueldo(){
    return _sueldo;
  }
  // public void set_sueldo(double pSueldo){
  //   _sueldo = pSueldo;
  // }
  public void set_sueldo(double pSueldo){
    if(pSueldo < 5000 || pSueldo > 15000){
      LogError("sueldo ilegal" + pSueldo.ToString());
    }else{
      _sueldo = pSueldo;
    }
  }
  public double get_sueldo(int pPassword){
    if(pPassword !=12345){
      LogError("Password ilegal");
      return 0.0;
    } else{
      return _sueldo;
    }
  }

  public double get_impuesto(){
    return _impuesto ;
  }
  public double get_impuesto(int pPassword){
    if(pPassword !=12345){
      LogError("Password Ilegal");
      return 0.0;
    }else{
      return _sueldo;
    }
  }

  //mutator
  public void CalculaImpuesto(){
    _impuesto = _sueldo * 0.16;
  }

  public void LogError(string msg){
    log += msg + "\r\n";
  }

  public void MuesraLog(){
    System.Console.WriteLine(log);
  }


  //PRINCIPIO DE DATA HIDDEN -ENCAPSULAMIENTO
}