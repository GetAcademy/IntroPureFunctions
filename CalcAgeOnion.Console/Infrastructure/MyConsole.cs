using CalcAgeOnion.Core._2_DomainServices;

namespace CalcAgeOnion.Console.Infrastructure
{
    internal class MyConsole : IConsole
    {
        public void Write(string text)
        {
            System.Console.Write(text);
        }

        public void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }

        public string ReadLine()
        {
            return System.Console.ReadLine()!;
        }
    }
}
