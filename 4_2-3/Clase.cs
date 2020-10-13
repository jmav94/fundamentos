class Clase
{
    private int _intNumero;
    public int Numero
    {
        get { return _intNumero; }
        set { _intNumero = value; }
    }
    public string Determinar(){
        string resultado = "";
        if (Numero == 0)
        {
            resultado = "El numero es 0";
        }
        if (Numero < 0)
        {
            resultado = "El numero es negativo";
        }
        if (Numero > 0)
        {
            resultado =  "El numero es positivo";
        }
        return resultado;
    }
}