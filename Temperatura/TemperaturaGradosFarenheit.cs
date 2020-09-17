class TemperaturaGradosFarenheit
{
    //atributo
    private double _dblGradosFarenheit = 0;
    // propiedad
    public double GradosFarenheit
    {
        set { _dblGradosFarenheit = value; }
    }
    // metodo
    public double ConvertiAGradosCentigrados(){
        return 5 * (_dblGradosFarenheit -32 )/9;
    }
}