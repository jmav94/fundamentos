class Divisa
{
    private int _intCantidad;
    public int Cantidad
    {
        get { return _intCantidad; }
        set { _intCantidad = value; }
    }
    private double _dblTipoCambio;
    public double TipoCambio
    {
        get { return _dblTipoCambio; }
        set { _dblTipoCambio = value; }
    }

    public double ConvertirADolares(){
        return Cantidad / TipoCambio;
    }
    
}