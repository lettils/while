class Program
{
    static void Main()
    {
        Console.Write("Digite o número limite: ");
        int limite = int.Parse(Console.ReadLine());

        int numero = 0;

        while (numero <= limite)
        {
            Console.WriteLine(numero);
            numero += 3;
        }
    }
}

