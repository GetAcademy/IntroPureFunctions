using CalcAgeOnion.Core._2_DomainServices;

namespace CalcAgeOnion.Core._1_ApplicationServices
{
    public class CalcAgeService
    {
        private readonly IConsole _console;
        private readonly IDateServices _dateServices;

        public CalcAgeService(IConsole console, IDateServices dateServices)
        {
            _dateServices = dateServices;
            _console = console;
        }
        public void Run()
        {
            _console.Write("Fødselsår: ");
            var birthYear = int.Parse(_console.ReadLine()!);

            _console.Write("Har du hatt bursdag i år? j/n: ");
            var hasHadBirthday = _console.ReadLine()! == "j";

            var currentYear = _dateServices.Now.Year;
            var age = currentYear - birthYear;

            if (!hasHadBirthday)
            {
                age--;
            }

            _console.WriteLine($"Du er {age} år.");
        }
    }
}
