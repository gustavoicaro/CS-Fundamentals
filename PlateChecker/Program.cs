namespace Fundamentals.PlateChecker;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine()!;

        bool isAlphanumeric = input.All(char.IsLetterOrDigit);
        bool isCorrectSize = input.Length == 7;
        bool firstThreeAreLetters = input[..3].All(char.IsLetter); // .Substring(0, 3)
        bool lastFourAreNumbers = input[^4..].All(char.IsNumber); // .Substring(input.Length - 4)

        if (!isAlphanumeric || !isCorrectSize || !firstThreeAreLetters || !lastFourAreNumbers)
        {
            Console.WriteLine("Falso");
            return;
        }

        Console.WriteLine("Verdadeiro");
    }
}