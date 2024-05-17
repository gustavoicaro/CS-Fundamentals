namespace Fundamentals.Doubles;
class Program
{
    private readonly double n1 = 1.3;
    private readonly double n2 = 3.6;

    static void Main()
    {
        Program doubles = new();

        Console.WriteLine(doubles.Sum());
        Console.WriteLine(doubles.Subtract());
        Console.WriteLine(doubles.Multiply());
        Console.WriteLine(doubles.Divide());
        Console.WriteLine(doubles.Average());
    }

    double Sum() => n1 + n2;

    double Subtract() => n1 - n2;

    double Multiply() => n1 * n2;

    double Divide()
    {
        if (n2 == 0)
            throw new DivideByZeroException();

        return n1 / n2;
    }

    double Average() => n1 + n2 / 2;
}
