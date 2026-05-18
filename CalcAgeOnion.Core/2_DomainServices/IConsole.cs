namespace CalcAgeOnion.Core._2_DomainServices
{
    public interface IConsole
    {
        void Write(string text);
        void WriteLine(string text);
        string ReadLine();
    }
}
