// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив      Новый массив будет выглядеть 
// выглядел вот так:                вот так:
// 1 4 7 2                          1 4 7 2
// 5 9 2 3                          5 81 2 9
// 8 4 2 4                          8 4 2 4

int m = EnterData("строк");
int n = EnterData("столбцов");
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers, "Базовый");
ChangeArray(numbers);
PrintArray(numbers, "Измененный");

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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
                array[i, j] *= array[i, j];
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

int EnterData(string text)
{
    Console.WriteLine($"Введите количество {text}: ");
    return Convert.ToInt32(Console.ReadLine());
}