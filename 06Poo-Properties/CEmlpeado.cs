namespace Properties;

public class CEmpleado{

  //attributes
  private double _sueldo;
  private double _impuesto;

  public void Muestra(){
    System.Console.WriteLine("Sueldo={0}, Impuesto={1}",_sueldo,_impuesto);
  }

  //PROPERTIES
  public double Sueldo {
    get {
      return _sueldo;
    }
    set{
      if(Sueldo > 5000)
        _sueldo = value;
      else
        _sueldo = 1;
    }
  }

  public double Impuesto{
    get{
      return _impuesto;
    }
    set{
      _impuesto = value;
    }
  }
  

  //mutator
  public void CalculaImpuesto(){
    _impuesto = _sueldo * 0.16;
  }



  //PRINCIPIO DE DATA HIDDEN -ENCAPSULAMIENTO
}