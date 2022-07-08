// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int row = EnterData("строк");
int column = EnterData("столбцов");
int[,] numbers = GetArray(row, column);
PrintArray(numbers, "Базовый");
int number = 0;
int amountCount = 0;
int amount = row * column;

while (amountCount < amount)
{
    int numberCount = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] == number)
            numberCount++;
        }
    }
    if (numberCount > 0)
    Console.WriteLine($"Число {number} встречается {numberCount} раз(а) ");
    number++;
    amountCount++;
}

void PrintArray(int[,] array, string text)
{
    Console.WriteLine($"{text} массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int line, int column)
{
    int[,] array = new int[line, column];
    FillArray(array);
    return array;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
}

int EnterData(string text)
{
    Console.WriteLine($"Введите количество {text} массива");
    return Convert.ToInt32(Console.ReadLine());
}