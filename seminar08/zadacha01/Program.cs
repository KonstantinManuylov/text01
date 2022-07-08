// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.WriteLine($"Задайте желаемые параметры массива: ");
int row = EnterData("Введите количество строк: ");
int column = EnterData("Введите количество столбцов: ");
int[,] numbers = GetArray(row, column);
PrintArray(numbers, "Базовый");
int[,] tempNumbers = numbers;
int[,] NewChangedArray = BuildNewArray(numbers, tempNumbers);
PrintArray(NewChangedArray, "Измененный");

int[,] BuildNewArray(int[,] array, int[,] tempArray)
{
    int[,] newArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (i > 0 && i < row - 1)
            {
                newArray[i, j] = array[i, j];
            }
            else
            {
                newArray[0, j] = array[row - 1, j];
                newArray[row - 1, j] = tempArray[0, j];
            }
        }
    }
    return newArray;
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