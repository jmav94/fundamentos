class Venta
{
    private double[] miArreglo = new double[12];
    public double this[int intPosicion]
    {
        get { return miArreglo[intPosicion]; }
        set { miArreglo[intPosicion] = value; }
    }
    public double CalcularPromedio(){
        double Promedio = 0.0;
        foreach (double mes in miArreglo)
        {
            Promedio += mes;
        }
        return Promedio / miArreglo.Length;
    }

    public double CalcularVentaMayor(){
        double ventaMayor = miArreglo[0];
        foreach (double mes in miArreglo)
        {
            if (mes > ventaMayor)
            {
                ventaMayor = mes;
            }
        } 
        return ventaMayor;
    }

    public string MostrarMesMenor(){
        string strMesLetras = "";
        double dblVentaMenor = miArreglo[0];
        int intCelda = 0;
        for (int i = 0; i < miArreglo.Length; i++)
        {
            if (miArreglo[i]<dblVentaMenor)
            {
                dblVentaMenor = miArreglo[i];
                intCelda = i+1;
            }
        }

        switch (intCelda)
        {
            case 1: strMesLetras = "Enero";break;
            case 2: strMesLetras = "Febrero";break;
            case 3: strMesLetras = "Marzo";break;
            case 4: strMesLetras = "Abril";break;
            case 5: strMesLetras = "Mayo";break;
            case 6: strMesLetras = "Junio";break;
            case 7: strMesLetras = "Julio";break;
            case 8: strMesLetras = "Agosto";break;
            case 9: strMesLetras = "Septiembre";break;
            case 10: strMesLetras = "Octubre";break;
            case 11: strMesLetras = "Novimebre";break;
            case 12: strMesLetras = "Diciembre";break;
        }
        return strMesLetras;
    }
}