using CalcAge;

//CalcAgeService.RunImpure();

Console.Write("Fødselsår: ");
var birthYear = int.Parse(Console.ReadLine()!);

Console.Write("Har du hatt bursdag i år? j/n: ");
var hasHadBirthday = Console.ReadLine()! == "j";

var age = CalcAgeService.RunPure(birthYear, hasHadBirthday);

Console.WriteLine($"Du er {age} år.");