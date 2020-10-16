class Venta
{
    private double _dblVentaMes;
    public double VentaMes
    {
        get { return _dblVentaMes; }
        set { _dblVentaMes = value; }
    }
    private double _dllVentaMayor;
    public double VentaMayor
    {
        get { return _dllVentaMayor; }
        set { _dllVentaMayor = value; }
    }
    
    public double EvaluarMayor(){
        if (VentaMes > VentaMayor)
        {
            VentaMayor = VentaMes;
        }
        return VentaMayor;
    }
}