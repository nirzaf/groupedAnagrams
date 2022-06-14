// See https://aka.ms/new-console-template for more information

var input = new List<string>{
    "inch",
    "cat",
    "chin",
    "kit",
    "act"};

int output = getGroupedAnagrams(input);

Console.WriteLine(output);


static int getGroupedAnagrams(List<string> words)
{
    var groupedAnagrams = new HashSet<string>();
    foreach (var word in words)
    {
        var charArray = word.ToCharArray();
        Array.Sort(charArray);
        groupedAnagrams.Add(getString(charArray));
        
    }
    
    return groupedAnagrams.Count;
}

static string getString(char[] arr)
{
    return new string(arr);
}
