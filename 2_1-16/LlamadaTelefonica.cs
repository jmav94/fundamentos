class LlamadaTelefonica
{
    // Atributo
    private double _dblDuracion;
    // Propiedad
    public double Duracion
    {
        set { _dblDuracion = value; }
    }
    
    // Metodo para calcular el costo de la llamada y devolver el resultado
    public double CalcularCosto(){
        return _dblDuracion * 3;
    }
}