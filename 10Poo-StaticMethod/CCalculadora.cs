namespace StaticMetods;

public class CCalculadora{
  private double a;
  private double b;
  private double r;

  public CCalculadora(double pa, double pb)
  {
    a = pa;
    b = pb;
  }
  public double R{
    get { return r; }
  }
  public void Suma(){
    r = a + b;
  }

  public void resta(){
    r = a - b;
  }

}