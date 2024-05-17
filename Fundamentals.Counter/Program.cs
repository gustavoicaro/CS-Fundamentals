namespace Fundamentals.Counter;
class Program
{
    static void Main()
    {
        var text = Console.ReadLine()!;
        int counter = 0;
        foreach (char character in text)
        {
            if (character != ' ')
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}