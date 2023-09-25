// ITERATE AND PRINT VALUES
Console.WriteLine("1. Iterate and Print Values");
static void PrintList(List<string> MyList)
{
    MyList.ForEach(Console.WriteLine);
}
List<string> TestStringList = new() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);


Console.WriteLine("\n********************\n");


// PRINT SUM
Console.WriteLine("2. Print Sum");
static void SumOfNumbers(List<int> IntList)
{
    int Sum = 0;
    for (int i = 0; i < IntList.Count; i++)
    {
        Sum += IntList[i];
    }
    Console.WriteLine(Sum);
}
List<int> TestIntList = new() {2, 7, 12, 9, 3};
SumOfNumbers(TestIntList);


Console.WriteLine("\n********************\n");


// FIND MAX
Console.WriteLine("3. Find Max");
static int FindMax(List<int> IntList)
{
    int maxVal = 0;
    for (int i = 0; i < IntList.Count; i++)
    {
        if (IntList[i] > maxVal)
        {
            maxVal = IntList[i];
        }
    }
    return maxVal;
}
List<int> TestIntList2 = new() {-9, 12, 10, 3, 17, 5};
Console.WriteLine(FindMax(TestIntList2));


Console.WriteLine("\n********************\n");


// SQUARE THE VALUES
Console.WriteLine("4. Square the Values");
static List<int> SquareValues(List<int> IntList)
{
    List<int> SquaredList = new();
    for (int i = 0; i < IntList.Count; i++)
    {
        SquaredList.Add(IntList[i] * IntList[i]);
    }
    return SquaredList;
}
List<int> TestIntList3 = new() {1, 2, 3, 4, 5};
SquareValues(TestIntList3).ForEach(Console.WriteLine);


Console.WriteLine("\n********************\n");


// REPLACE NEGATIVE NUMBERS WITH 0
Console.WriteLine("5. Replace Negative Numbers With 0");
static int[] NonNegatives(int[] IntArray)
{
    int[] NonNegativeArray = new int[IntArray.Length];
    for (int i = 0; i < IntArray.Length; i++)
    {
        NonNegativeArray[i] = IntArray[i] > 0 ? IntArray[i] : 0;

        if (i == 0 || i == IntArray.Length - 1)
        {
            Console.Write(i == 0 ? $"[{NonNegativeArray[i]}, ": $"{NonNegativeArray[i]}]");
        }
        else
        {
            Console.Write($"{NonNegativeArray[i]}, ");
        }
    }
    return NonNegativeArray;
}
int[] TestIntArray = new int[] {-1, 2, 3, -4, 5};
NonNegatives(TestIntArray);


Console.WriteLine("\n********************\n");


// PRINT DICTIONARY
Console.WriteLine("6. Print Dictionary");
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (KeyValuePair<string,string> entry in MyDictionary)
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
}
Dictionary<string,string> TestDict = new();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);


Console.WriteLine("\n********************\n");


// FIND KEY
Console.WriteLine("7. Find Key");
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    return MyDictionary.ContainsKey(SearchTerm);
}
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));


Console.WriteLine("\n********************\n");


// GENERATE A DICTIONARY
Console.WriteLine("8. Generate A Dictionary");
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string,int> MyDict = new();

    for (int i = 0; i < Names.Count; i++)
    {
        MyDict.Add(Names[i], Numbers[i]);
    }
    
    return MyDict;
}
List<string> GenTestStringList = new() {"Julie", "Harold", "James", "Monica"};
List<int> GenTestIntList = new() {6, 12, 7, 10};
foreach (KeyValuePair<string,int> entry in GenerateDictionary(GenTestStringList, GenTestIntList))
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
