class Carretera
{
    private double _dblLongitud;
    public double Longitud
    {
        get { return _dblLongitud; }
        set { _dblLongitud = value; }
    }
    public double ConvertirAMetros(){
        return Longitud * 1000;
    }
    
}