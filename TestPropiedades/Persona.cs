class Persona
{
    private string _strNombre;
    public string Nombre
    {
        get { return _strNombre; }
        set { _strNombre = value; }
    }
    int _intEdad;
    public int Edad
    {
        set { _intEdad = value; }
    }
    private double _dblSueldo;
    public double Sueldo
    {
        get { return _dblSueldo; }
    }
    
}