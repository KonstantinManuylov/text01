// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"] ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] words = {  "hello", "2", "world", ":-)", "1234", "1567",
                    "-2", "computer science", "Russia", "Denmark", "Kazan"};

// System.Console.WriteLine(TruePrint(words));
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