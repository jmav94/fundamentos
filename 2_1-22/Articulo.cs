class Articulo
{
    private string _strNombre;
    public string Nombre
    {
        get { return _strNombre; }
        set { _strNombre = value; }
    }
    private double _dblPrecio;
    public double Precio
    {
        get { return _dblPrecio; }
        set { _dblPrecio = value; }
    }
    private int _intCantidadVendida;
    public int CantidadVendida
    {
        get { return _intCantidadVendida; }
        set { _intCantidadVendida = value; }
    }
    
    public double CalcularIVA(){
        return Precio * .16;
    }

    public double CalcularDescuento(){
        return Precio * .02;
    }

    public double CalcularSubtotal(){
        return CantidadVendida * (Precio - CalcularDescuento()) ;
    }

    public double CalcularTotal(){
        return CantidadVendida * (Precio + CalcularIVA() - CalcularDescuento());
        //return CantidadVendida * (Precio *1.16 - Precio*.02);
    }
    
}