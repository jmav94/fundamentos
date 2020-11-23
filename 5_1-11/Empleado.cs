class Empleado
{
    private int _intNumero;
    public int Numero
    {
        get { return _intNumero; }
        set { _intNumero = value; }
    }
    private string _strApellidoP;
    public string ApellidoP
    {
        get { return _strApellidoP; }
        set { _strApellidoP = value; }
    }
    private string _strApellidoM;
    public string ApellidoM
    {
        get { return _strApellidoM; }
        set { _strApellidoM = value; }
    }
    private string _strNombre;
    public string Nombre
    {
        get { return _strNombre; }
        set { _strNombre = value; }
    }
    private int _intHorasTrabajadas;
    public int Horastrabajadas
    {
        get { return _intHorasTrabajadas; }
        set { _intHorasTrabajadas = value; }
    }
    private double _dblSueldoPHora;
    public double SueldoPHora
    {
        get { return _dblSueldoPHora; }
        set { _dblSueldoPHora = value; }
    }
    public double SueldoNeto(){
        return SueldoPHora * Horastrabajadas;
    }
}