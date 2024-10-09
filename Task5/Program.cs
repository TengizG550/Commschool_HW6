Console.WriteLine("Enter passed distance for each day. Enter all numbers on same line, each separated by single whitespace");
var passedDistances = Console.ReadLine().Split(" ");
var progressCounter = 0;
if (passedDistances.Length > 1) {
    for (int i = 1; i < passedDistances.Length; i++)
    {
        if (Convert.ToInt32(passedDistances[i]) > Convert.ToInt32(passedDistances[i - 1]))
            progressCounter++;
} 
}
Console.WriteLine(progressCounter);
