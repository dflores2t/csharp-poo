namespace AccesoSealed;

sealed class CEmpleado : CPersona
{
  private string _puesto;
  private double _salario;

  //CONSTRUCTUR HERENCIA

  public CEmpleado(string pNombre, int pEdad, string pPuesto, double pSalario) : base(pNombre, pEdad)
  {
    System.Console.WriteLine("CONSTRUCTUR EMPLEADO");
    _puesto = pPuesto;
    _salario = pSalario;
  }

  public string Puesto { get => _puesto; set => _puesto = value; }
  public double Salario { get => _salario; set => _salario = value; }

  public void PonerDatos(string pNombre, int pEdad, string pPuesto, double pSalario)
  {
    //recibo la informacion pero no estoy llevando ningun tipo de verificacion. siguiendo el ejemplo de program de modificar edad directamente. veremos que salta la validadcion de la propiedad Edad.
    // Nombre = pNombre;  //propiedad de la clase padre
    // Edad = pEdad;
    _puesto = pPuesto;
    _salario = pSalario;
    _nombre = pNombre;
    _edad = pEdad;
  }

  public void EmpleadoMuestra()
  {
    Muestra();
    System.Console.WriteLine("Trabajo de {0} con sueldo de ${1}", _puesto, _salario);
  }


}