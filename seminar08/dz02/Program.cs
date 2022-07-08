// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine($"Задайте размер массива: ");
int line = EnterData("строк");
int column = EnterData("столбцов");
int[,] numbers = GetArray(line, column);
PrintArray(numbers, "Базовый");
int lineNumber = 0;
int tempLineSum = int.MaxValue;
int lineLessSum = 0;
int lineSum = 0;

while (lineNumber <= line - 1)
{
    for (int i = 0; i < column; i++)
    {
        lineSum += numbers[lineNumber, i];
    }
    if (tempLineSum > lineSum)
    {
        tempLineSum = lineSum;
        lineLessSum = lineNumber;
    }
    lineNumber++;
    lineSum = 0;
}
Console.WriteLine($"У строки {lineLessSum + 1} минимальная сумма чисел {tempLineSum}");

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