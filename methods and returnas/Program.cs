namespace methods_and_returnas;

internal static class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("Hello Amos please choose your fist number: ");
        var x = int.Parse(Console.ReadLine());
        Console.Write("Now the second: ");
        var y = int.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {Multi(x, y):N0}");//
    }

    private static int Multi(int x, int y) => x * y;
}
