Console.WriteLine("Enter radius of circle");
var r = Convert.ToDouble(Console.ReadLine());
var areaOfOuterSquare = 4 * r * r;
var areaOfInnerSquare = 2 * r * r;
Console.WriteLine($"Area of outer square is {areaOfOuterSquare}");
Console.WriteLine($"Area of inner square is {areaOfInnerSquare}");
Console.WriteLine($"Difference between area of outer square and area of inner square is {areaOfOuterSquare - areaOfInnerSquare}");
