namespace Fundamentals.Concat;
class Program
{
    static void Main()
    {
        string? firstName = null;
        string? lastName = null;

        while (string.IsNullOrWhiteSpace(firstName))
        {
            Console.Write("Nome: ");
            firstName = Console.ReadLine();
        }

        while (string.IsNullOrWhiteSpace(lastName))
        {
            Console.Write("Sobrenome: ");
            lastName = Console.ReadLine();
        }

        Console.WriteLine("{0} {1}", firstName, lastName);
    }
}
 