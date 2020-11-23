class Operacion
{
    public double Factorial(int num){
        int Factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            Factorial *= i;
            //Factorial = Factorial * i;
        }
        return Factorial;
    }
}