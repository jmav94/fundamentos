class Automovil
{
    private string _strMarca;
    public string Marca
    {
        get { return _strMarca; }
        set { _strMarca = value; }
    }
    
    private string _strModelo;
    public string Modelo
    {
        get { return _strModelo; }
        set { _strModelo = value; }
    }
    private int _intAnio;
    public int Anio
    {
        get { return _intAnio; }
        set { _intAnio = value; }
    }
    private double _dblCosto;
    public double Costo
    {
        get { return _dblCosto; }
        set { _dblCosto = value; }
    }
    
    // Metodo
    public double CalcularCostoTotal(){
        return Costo + (Costo * .12 ) + (Costo * .06);
    }
    
}