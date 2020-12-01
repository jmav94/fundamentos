class Estudiante
{
    private string _strNoCtrl;
    public string NoCtrl
    {
        get { return _strNoCtrl; }
        set { _strNoCtrl = value; }
    }
    private string _strNombre;
    public string Nombre
    {
        get { return _strNombre; }
        set { _strNombre = value; }
    }
    int[] miArregloCalificaciones = new int[3];
    public int this[int intCelda]{
        get{ return miArregloCalificaciones[intCelda]; }
        set{ miArregloCalificaciones[intCelda] = value;}
    }
    public double CalcularPromedio(){
        /*double dblSuma;
        dblSuma = 0.0;*/
        double dblSuma = 0.0;
        foreach (int intCalificacion in miArregloCalificaciones)
        {
            //dblSuma = dblSuma + intCalificacion;
            dblSuma +=  intCalificacion;
        }
        return dblSuma / 3;
    }
}