class Estudiante
{
    private int _intPromedio;
    public int Promedio
    {
        get { return _intPromedio; }
        set { _intPromedio = value; }
    }
    public char VerificarGrupo(){
        if (Promedio >= 90 && Promedio <= 100)
        {
            return 'A';
        }else if (Promedio >= 80 && Promedio <=89)
        {
            return 'B';
        }else{
            return 'C';
        }
    }
}