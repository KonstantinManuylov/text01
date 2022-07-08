// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine($"Задайте размер массива: ");
int line = EnterData("строк");
int column = EnterData("столбцов");
int[,] numbers = GetArray(line, column);
PrintArray(numbers, "Базовый");
int[,] changedArray = ChangedArray(numbers);
PrintArray(changedArray, "Измененный");

int[,] ChangedArray(int[,] array)
{
    int[,] newArray = new int[column, line];
    for (int j = 0; j < newArray.GetLength(0); j++)
    {
        for (int i = 0; i < newArray.GetLength(1); i++)
        {
            newArray[j, i] = array[i, j];
        }
    }
    return newArray;
}

void PrintArray(int[,] array, string text)
{
    Console.WriteLine($"{text} Массив");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int row, int column)
{
    int[,] array = new int[row, column];
    FillArray(array);
    return array;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 101);
        }
    }
}

int EnterData(string text)
{
    Console.WriteLine($"Введите количество {text} массива: ");
    return Convert.ToInt32(Console.ReadLine());
}