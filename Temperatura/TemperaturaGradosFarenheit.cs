class TemperaturaGradosFarenheit
{
    // Atributo
    private double _dblGradosFarenheit;
    // Propiedad
    public double GradosFarenheit
    {
        set { _dblGradosFarenheit = value; }
    }
    // Metodo
    public double ConvertiAGradosCentigrados(){
        return 5 * (_dblGradosFarenheit -32 )/9;
    }
}