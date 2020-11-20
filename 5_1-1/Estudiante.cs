class Estudiante
{
    private int _intNLista;
    public int NLista
    {
        get { return _intNLista; }
        set { _intNLista = value; }
    }
    
    private string _strAP;
    public string APaterno
    {
        get { return _strAP; }
        set { _strAP = value; }
    }
    private string _strAM;
    public string AMaterno
    {
        get { return _strAM; }
        set { _strAM = value; }
    }
    private string _strNombres;
    public string Nombres
    {
        get { return _strNombres; }
        set { _strNombres = value; }
    }
    private char _chrGrupo;
    public char Grupo
    {
        get { return _chrGrupo; }
        set { _chrGrupo = value; }
    }
    private double _dblPromedio;
    public double Promedio
    {
        get { return _dblPromedio; }
        set { _dblPromedio = value; }
    }
}