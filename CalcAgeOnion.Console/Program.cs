

using CalcAgeOnion.Console.Infrastructure;
using CalcAgeOnion.Core._1_ApplicationServices;

var myConsole = new MyConsole();
var myDateServices = new MyDateServices();
var calcAgeService = new CalcAgeService(myConsole, myDateServices);
calcAgeService.Run();