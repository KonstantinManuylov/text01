// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine($"Задайте желаемые параметры массива: ");
int row = EnterData("Введите количество строк: ");
int column = EnterData("Введите количество столбцов: ");
int[,] numbers = GetArray(row, column);
int m = EnterData("Введите желаемую строку: ");
int n = EnterData("Введите желаемый столбец: ");
PrintArray(numbers, "Базовый");
int findNumber = FindNumber(numbers, m, n);
if (m > row || m < 1 || n < 1 || n > column)
{
    Console.WriteLine($"Числа в позиции {m} {n} в массиве нет.");
}
else Console.WriteLine($"В позиции {m} {n} находится число: {findNumber}");

int FindNumber(int[,] array, int row, int column)
{
    int find = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row && j == column)
                find = array[i, j];
        }
    }
    return find;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array, string text)
{
    Console.WriteLine($"{text} массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int strings, int columns)
{
    int[,] array = new int[strings, columns];
    FillArray(array);
    return array;
}

int EnterData(string text)
{
    Console.WriteLine($"{text}");
    return Convert.ToInt32(Console.ReadLine());
}