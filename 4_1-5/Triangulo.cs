using System;
class Triangulo
{
    private int _intL1;
    public int L1
    {
        get { return _intL1; }
        set { _intL1 = value; }
    }
    
    private int _intL2;
    public int L2
    {
        get { return _intL2; }
        set { _intL2 = value; }
    }
    private int _intL3;
    public int L3
    {
        get { return _intL3; }
        set { _intL3 = value; }
    }
    

    public double CalcularArea(){
        double T;
        T = (_intL1 + _intL2 + _intL3) / 2;
        return Math.Pow( (T * (T-_intL1) * (T-_intL2) * (T-_intL3)),.5);
    }
}