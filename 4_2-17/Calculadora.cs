using System;
class Calculadora
{
    private int n1;
    public int N1
    {
        get { return n1; }
        set { n1 = value; }
    }
    private int n2;
    public int N2
    {
        get { return n2; }
        set { n2 = value; }
    }
    public int Suma(){
        return N1 + N2;
    }
    public int Resta(){
        return N1 - N2;
    }
    public double Multiplicacion(){
        return N1 * N2;
    }
    public int DivisionEntera(){
        return N1 / N2;
    }
    public double Division(){
        return (double) N1 / N2;
    }
    public double Potencia(){
        return Math.Pow(N1,N2);
    }
}