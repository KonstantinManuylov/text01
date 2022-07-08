string[] words = {  "hello", "2", "world", ":-)", "1234", "1567",
                    "-2", "computer science", "Russia", "Denmark", "Kazan"};
string[] finishWords = NewWords(words);
Console.WriteLine(TruePrint(finishWords));

string[] NewWords(string[] array)
{
    string[] finishArray = new string[Range(array)];
    int charAmount = 3;
    int index = 0;
    string temp = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= charAmount)
        {
            finishArray[index] = array[i];
            index++;
        }
    }
    return finishArray;
}

int Range(string[] array)
{
    int charAmount = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= charAmount)
            count++;
    }
    return count;
}

string TruePrint(string[] array)
{
    string res = string.Empty;
    int size = array.Length;
    res = "[ ";
    for (int i = 0; i < size; i++)
    {
        res += $"{array[i],3} ";
    }
    res += "]";
    return res;
}