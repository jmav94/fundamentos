class Articulo
{
    private int _intClaveNumerica;
    public int ClaveNumerica
    {
        get { return _intClaveNumerica; }
        set { _intClaveNumerica = value; }
    }
    private string _strDescripcion;
    public string Descripcion
    {
        get { return _strDescripcion; }
        set { _strDescripcion = value; }
    }
    private double _dblPrecio;
    public double Precio
    {
        get { return _dblPrecio; }
        set { _dblPrecio = value; }
    }
    private int _intCantidadEnExistencia;
    public int CantidadEnExistencia
    {
        get { return _intCantidadEnExistencia; }
        set { _intCantidadEnExistencia = value; }
    }
    
}