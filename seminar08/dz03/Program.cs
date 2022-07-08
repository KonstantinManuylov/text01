// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.





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