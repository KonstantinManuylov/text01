// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int m = EnterData("строк");
int n = EnterData("столбцов");
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine($"Массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int EnterData(string text)
{
    Console.WriteLine($"Введите количество {text}: ");
    return Convert.ToInt32(Console.ReadLine());
}