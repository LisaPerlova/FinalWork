string[] array = new string[6] { "l", "hello", "world", "hsd", "123", ":)" };
string[] newArray = new string[array.Length];

void WordsWith3Symbols(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
WordsWith3Symbols(array, newArray);
PrintArray(newArray);
