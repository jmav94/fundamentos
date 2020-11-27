class Operacion
{
    public double Factorial(int num){
        int Resultado = 1;
        for (int i = 1; i <= num; i++)
        {
            Resultado *= i;
            //Resultado = Resultado * i;
        }
        return Resultado;
    }
}