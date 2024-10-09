var n = Convert.ToInt32(Console.ReadLine());
var words = Console.ReadLine().Split(' ' , StringSplitOptions.RemoveEmptyEntries).Where(elem => elem.Length >= n);
if (words.Any())
{
    foreach (var word in words)
    {
        Console.Write(word + " ");
    }
} else Console.WriteLine("No elements found");

