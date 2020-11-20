class Poliza
{
    private string _strNombre;
    public string Nombre
    {
        get { return _strNombre; }
        set { _strNombre = value; }
    }
    private int _intEdad;
    public int Edad
    {
        get { return _intEdad; }
        set { _intEdad = value; }
    }
    private double _dblValorAuto;
    public double ValorAuto
    {
        get { return _dblValorAuto; }
        set { _dblValorAuto = value; }
    }
    private int _strModelo;
    public int Modelo
    {
        get { return _strModelo; }
        set { _strModelo = value; }
    }
    private int _intNumeroAccidentes;
    public int NumeroAccidentes
    {
        get { return _intNumeroAccidentes; }
        set { _intNumeroAccidentes = value; }
    }
    public double CalcularCosto(){
         double CargoPModelo, CargoPEdad,CargoPAccidentes;
         if (Edad > 65 )
         {
             return 0;
         }       
         if (Modelo <= 90)
         {
             CargoPModelo = ValorAuto *.001;
         }else if (Modelo >=91 && Modelo <=97)
         {
             CargoPModelo = ValorAuto *.003;
         }else 
         {
             CargoPModelo = ValorAuto *.005;
         }
         if (Edad >= 18 && Edad <= 23)
         {
             CargoPEdad = 350;
         }else if (Edad <= 55)
         {
             CargoPEdad = 200;
         }
         else{
             CargoPEdad = 400;
         }
         if (NumeroAccidentes <= 3)
         {
             CargoPAccidentes = NumeroAccidentes * 15;
         }else{
             CargoPAccidentes = (NumeroAccidentes -3) * 20 + 45;
         }
         return (ValorAuto *.03) + CargoPModelo + CargoPEdad + CargoPAccidentes;
    }
}