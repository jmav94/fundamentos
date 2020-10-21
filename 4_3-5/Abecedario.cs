class Abecedario
{
    public string ImprimirAbecedario(){
        string resultado = "";
        for (char i = 'A'; i <= 'Z'; i++)
        {
            /*if (i == 'Z')
            {
                resultado+=$"{i}.";
            }else{
                resultado += $"{i}, ";
            }*/
            if (i != 'Z')
                resultado += $"{i}, ";
            else 
                resultado+=$"{i}.";
                        
        }
        return resultado;
    }
}