using static System.Console;

namespace ConsoleApplication
{
    /*
    * tutorial founded here:
    * https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/using-with-xplat-cli
    */
    public class Program
    {
        public static int FibonacciNumber(int n) 
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }
        public static void Main(string[] args)
        {
            WriteLine("Fibonacci Numbers 1-15:");

            for (int i = 0; i < 15; i++)
            {
                WriteLine($"{i+1}: {FibonacciNumber(i)}");
            }
        }
    }
}
