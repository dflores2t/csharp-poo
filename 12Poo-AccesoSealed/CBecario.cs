namespace AccesoSealed;

// public class CBecaario : CEmpleado //cbecaario no puede derivar del tipo sellad
public class Cbecario: CPersona
{
  private int horasBeca;

  public Cbecario(string pNombre, int pEdad, int pHoras): base(pNombre, pEdad)
  {
    horasBeca = pHoras;
  }

  public int HorasBeca{
    get{
      return horasBeca;
    }
    set{
      horasBeca = value;
    }
  }

  public void MuestraBecario(){
    System.Console.WriteLine("Cantidad de horas: {0}", horasBeca);
  }
}