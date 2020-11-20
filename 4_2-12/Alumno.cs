using System;
class Alumno
{
    private int c1;
    public int C1
    {
        get { return c1; }
        set { c1 = value; }
    }
    private int c2;
    public int C2
    {
        get { return c2; }
        set { c2 = value; }
    }
    private int c3;
    public int C3
    {
        get { return c3; }
        set { c3 = value; }
    }
    private bool Promedio(){
        double resultado;
        resultado = (C1 +C2 + C3) / 3;
        /*if (resultado >= 70)
        {
            return true;
        }else{
            return false;
        }*/
        return resultado >= 70 ? true : false;
    }
    public string Aprobado(){
        /*if (Promedio())
        {
            return "El alumno esta aprobado";
        }else{
            return "El alumno no esta aprobado";
        }*/
        //return Promedio() ? "El alumno esta aprobado" :"El alumno no esta aprobado";
        return $"El alumno {(Promedio() ? "esta ": "no esta")} aprobado" ;
    }
}