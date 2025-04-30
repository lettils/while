
class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int N = int.Parse(Console.ReadLine());

        int numero = 2;

        while (numero <= N)
        {
            Console.WriteLine(numero);
            numero += 2; 
        }
    }
}

