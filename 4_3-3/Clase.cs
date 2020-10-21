class Clase
{
    private int _intNumero;
    public int Numero
    {
        get { return _intNumero; }
        set { _intNumero = value; }
    }
    public int Suma(){
        int suma=0;
        for (int i = 0; i <= Numero; i++)
        {
            suma +=i;
        }
        return suma;
    }
}