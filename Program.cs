using static System.Console;
using Numbers;

namespace ConsoleApplication
{
    /*
    * tutorial founded here:
    * https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/using-with-xplat-cli
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            var generator = new FibonacciGenerator();
            
            WriteLine("Fibonacci sequence 1-15:");
            foreach (var digit in generator.Generate(15))
            {
                WriteLine(digit);
            }
        }
    }
}
