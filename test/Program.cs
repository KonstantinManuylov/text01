string[] words = {  "hello", "2", "world", ":-)", "1234", "1567",
                    "-2", "computer science", "Russia", "Denmark", "Kazan"};
string[] finishWords = NewWords(words);

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