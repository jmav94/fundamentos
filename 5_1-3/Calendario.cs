class Calendario
{
    private int _intMes;
    public int Mes
    {
        get { return _intMes; }
        set { _intMes = value; }
    }
    public string MesConLetra(){
        string MesL= "";
        switch (Mes)
        {
            case 1: MesL = "Enero";break;
            case 2: MesL = "Febrero";break;
            case 3: MesL = "Marzo";break;
            case 4: MesL = "Abril";break;
            case 5: MesL = "Mayo";break;
            case 6: MesL = "Junio";break;
            case 7: MesL = "Julio";break;
            case 8: MesL = "Agosto";break;
            case 9: MesL = "Septiembre";break;
            case 10: MesL = "Octubre";break;
            case 11: MesL = "Noviembre";break;
            case 12: MesL = "Diciembre";break;
        }
        return MesL;
    }
    public string MesConLetra(int numero){
        string MesL= "";
        switch (numero)
        {
            case 1: MesL = "Enero";break;
            case 2: MesL = "Febrero";break;
            case 3: MesL = "Marzo";break;
            case 4: MesL = "Abril";break;
            case 5: MesL = "Mayo";break;
            case 6: MesL = "Junio";break;
            case 7: MesL = "Julio";break;
            case 8: MesL = "Agosto";break;
            case 9: MesL = "Septiembre";break;
            case 10: MesL = "Octubre";break;
            case 11: MesL = "Noviembre";break;
            case 12: MesL = "Diciembre";break;
        }
        return MesL;
    }
}