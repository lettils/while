class Program
{
    static void Main()
    {
      
        int contador = 10;
        Console.WriteLine("Contagem regressiva:");
        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador--;
        }

       
        contador = 1;
        Console.WriteLine("Contagem crescente:");
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }
    }
}

