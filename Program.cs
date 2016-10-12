using static System.Console;
using System.Collections.Generic;

using Numbers;
using Pets;

namespace ConsoleApplication
{
    /*
    * tutorial founded here:
    * https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/using-with-xplat-cli
    */
    public class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("Usage:");
                WriteLine("fib: generate Fibonacci sequence 1-15");
                WriteLine("pets: pet classes tutorial");
                return 1;
            }

            switch (args[0])
            {
                case "fib":
                    var generator = new FibonacciGenerator();
                    
                    WriteLine("Fibonacci sequence 1-15:");
                    foreach (var digit in generator.Generate(15))
                    {
                        WriteLine(digit);
                    } 
                    break;
                case "pets":
                    List<IPet> pets = new List<IPet>()
                    {
                        new Dog(),
                        new Cat()
                    };

                    string talk; 
                    foreach (var pet in pets)
                    {
                        talk = pet.TalkToOwner();
                        WriteLine(talk);
                    }

                    break;
                default:
                    WriteLine("Unrecognized command");
                    break;
            }

            return 0;
        }
    }
}
