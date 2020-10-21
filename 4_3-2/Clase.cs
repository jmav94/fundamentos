class Clase
{
    public string CadenaNumeros(){
        string strNumeros = "";
        for (int i = 25; i >= 15; i--)
        {
            strNumeros += $"{i}, ";
        }
        return strNumeros;
    }
}