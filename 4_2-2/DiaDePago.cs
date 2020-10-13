class DiaDePago
{
    private string _strDia;
    public string Dia
    {
        get { return _strDia; }
        set { _strDia = value; }
    }
    public bool VerificarDia(){
        bool Resultado = false;
        /*if (Dia == "Viernes")
        {
            Resultado = true;
        }
        if (Dia == "VIERNES")
        {
            Resultado = true;
        }
        if (Dia == "viernes")
        {
            Resultado = true;
        }*/
        if (Dia.ToLower() == "viernes")
        {
            Resultado = true;
        }
        return Resultado;
        
    }
}
