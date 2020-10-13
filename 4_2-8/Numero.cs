class Numero
{
    private int _intValor;
    public int Valor
    {
        get { return _intValor; }
        set { _intValor = value; }
    }
    public bool EsPar(){
        if (Valor % 2 == 0)
        {
            return true;
        }else{
            return false;
        }
    }
}