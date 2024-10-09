Console.WriteLine("Enter wins");
var wins = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter draws");
var draws = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter loses");
var loses = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(wins * 3 + draws);