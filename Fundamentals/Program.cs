namespace Fundamentals.Doubles;
class Program
{
    static void Main()
    {
        string? name = null;

        Console.WriteLine("Qual seu nome?");

        while (string.IsNullOrWhiteSpace(name))
        {
            name = Console.ReadLine();
        }

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }
}
