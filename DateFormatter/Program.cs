namespace Fundamentals.DateFormatter;
class Program
{
    static void Main()
    {
        Console.WriteLine(FullDateTime());
        Console.WriteLine(RegularDate());
        Console.WriteLine(TwentyFourHours());
        Console.WriteLine(DayAndMonthInFull());
    }

    static string FullDateTime()
    {
        var date = DateTime.Now;
        // return date.ToLongDateString() + ", " + date.ToLongTimeString();
        return date.ToString("F");
    }

    static string RegularDate()
    {
        var date = DateTime.Now;
        return date.ToShortDateString();
    }
    static string TwentyFourHours()
    {
        var date = DateTime.Now;
        return date.ToShortTimeString();
    }
    static string DayAndMonthInFull()
    {
        var date = DateTime.Now;
        return date.ToString("M");
    }
}