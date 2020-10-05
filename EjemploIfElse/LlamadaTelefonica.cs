class LlamadaTelefonica
{
    private int _intDuracion;
    public int Duracion
    {
        get { return _intDuracion; }
        set { _intDuracion = value; }
    }
    public int CalcularCosto(){
        if (Duracion <=3)
        {
            return 5;    
        }else {
            return (Duracion - 3) * 3 + 5;  
        }
    }
    
}