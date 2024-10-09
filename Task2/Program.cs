using System.Linq;

List<string> inputElements = new List<string>();
while (true)
{
    var input = Console.ReadLine();
    if (input.Trim() != "")
    inputElements.Add(input);
    else break;


}
Dictionary<string,int> listOfUniqueElementsAndItoccurrences = new Dictionary<string, int>();

for (int i = 0; i < inputElements.Count; i++)
{
    if (!listOfUniqueElementsAndItoccurrences.ContainsKey(inputElements[i]))
        listOfUniqueElementsAndItoccurrences.Add(inputElements[i], 1);
    else listOfUniqueElementsAndItoccurrences[inputElements[i]]++;

}

if (listOfUniqueElementsAndItoccurrences.First().Value == inputElements.Count)
{
    Console.WriteLine("Yes");
} else Console.WriteLine("No");