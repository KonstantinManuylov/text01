// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine($"Задайте желаемые параметры массива: ");
int row = EnterData("Введите количество строк: ");
int column = EnterData("Введите количество столбцов: ");
int[,] numbers = GetArray(row, column);
PrintArray(numbers, "Базовый");
int columnNumber = 0;
double divider = row;
while (columnNumber < column)
{
    double count = 0;
    int sum = 0;
    for (int i = 0; i < row; i++)
    {
        sum += numbers[i, columnNumber];
    }
    count = sum / divider;
    Console.WriteLine($"Среднее арифметическое столбца {columnNumber + 1}: {Math.Round(count, 2)}");
    columnNumber++;
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