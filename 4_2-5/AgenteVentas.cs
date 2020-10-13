public class AgenteVentas
{
    private string _strNombre;
    public string Nombre
    {
        get { return _strNombre; }
        set { _strNombre = value; }
    }
    private int _intCantidad;
    public int Cantidad
    {
        get { return _intCantidad; }
        set { _intCantidad = value; }
    }
    public string CalcularSueldo()
    {
        double dblSueldoBruto, dblImpuesto, dblSueldoNeto;
        dblSueldoBruto = 350 + (Cantidad * 15);
        if (Cantidad > 15)
        {
            dblSueldoBruto += 40;
            //dblSueldoBruto = dblSueldoBruto + 40;
        }
        dblImpuesto = dblSueldoBruto * .05;
        dblSueldoNeto = dblSueldoBruto-dblImpuesto;

        return $"El sueldo bruto es de: {dblSueldoBruto} \nEl impuesto es de: {dblImpuesto} \nEl sueldo neto es de : {dblSueldoNeto}";
    }
}