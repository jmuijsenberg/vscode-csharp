using Greeting;

namespace DsmSuite.Analyzer.Compare
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Greet greet = new Greet();
            Console.WriteLine(greet.GetText());
        }
    }
}

