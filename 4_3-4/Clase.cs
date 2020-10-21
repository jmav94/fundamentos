class Clase
{
    public int SumaImpares(){
        int suma= 0;
        for (int i = 20; i <= 150 ; i++)
        {
            if (i % 2 != 0)
            {
                suma += i;
            }
        }
        return suma;
    }
}