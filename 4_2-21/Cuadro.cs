class Cuadro
{
    private double _dblMedida;
    public double Medida
    {
        get { return _dblMedida; }
        set { _dblMedida = value; }
    }
    public bool VerificarMedida(){
        /*if (Medida >= 4.8 && Medida <= 5.2)
        {
            return true;
        }else{
            return false;
        }*/
        return (Medida >= 4.8 && Medida <= 5.2);

    }
}