using System;

namespace ProgramToAmos
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            double x;
            double y;
            double result;
            
            Console.WriteLine("Hello Amos please choose your fist number");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now the second");
            y = Convert.ToDouble(Console.ReadLine());
            result = Multi(x, y);
            
            Console.WriteLine(result);
        }

        static double Multi(double x, double y)
        {
            double z = x * y;
            return z;
        }
    }
    
}
