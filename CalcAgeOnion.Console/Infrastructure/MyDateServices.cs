using CalcAgeOnion.Core._2_DomainServices;

namespace CalcAgeOnion.Console.Infrastructure
{
    internal class MyDateServices : IDateServices
    {
        public DateTime Now => DateTime.Now;
    }
}
