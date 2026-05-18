namespace CalcAge
{
    internal class CalcAgeService
    {
        public static int RunPure(int birthYear, bool hasHadBirthday, int currentYear)
        {
            var birthdayAdjustment = hasHadBirthday ? 0 : -1;
            return currentYear - birthYear + birthdayAdjustment;
        }

        public static void RunImpure()
        {
            Console.Write("Fødselsår: ");
            var birthYear = int.Parse(Console.ReadLine()!);

            Console.Write("Har du hatt bursdag i år? j/n: ");
            var hasHadBirthday = Console.ReadLine()! == "j";

            var currentYear = DateTime.Now.Year;
            var age = currentYear - birthYear;

            if (!hasHadBirthday)
            {
                age--;
            }

            Console.WriteLine($"Du er {age} år.");
        }
    }
}
