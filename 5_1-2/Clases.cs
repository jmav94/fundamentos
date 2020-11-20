using System;
class GalletaCircular
{
    private double _dblRadio;
    public double Radio
    {
        get { return _dblRadio; }
        set { _dblRadio = value; }
    }
    public double CalcularArea(){
        //double area = Math.PI * Math.Pow(Radio,2);
        return Math.Round(Math.PI * Math.Pow(Radio,2), 2);
    }
}

class GalletaCuadrada
{
    private double _dblLado;
    public double Lado
    {
        get { return _dblLado; }
        set { _dblLado = value; }
    }
    public double CalcularArea(){
        return Math.Round(Lado * Lado,2);
    }
}

class GalletaRectangular
{
    private double _dblBase;
    public double Base
    {
        get { return _dblBase; }
        set { _dblBase = value; }
    }
    private double _dblAltura;
    public double Altura
    {
        get { return _dblAltura; }
        set { _dblAltura = value; }
    }
    public double CalcularArea(){
        return Math.Round(Base * Altura,2);
    }
}