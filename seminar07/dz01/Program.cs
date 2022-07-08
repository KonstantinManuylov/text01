// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = EnterData("строк");
int n = EnterData("столбцов");
double[,] numbers = new double[m, n];
FillArray(numbers);
PrintArray(numbers);

void FillArray(double[,] array)
{
    Random rnd = new Random();
    double min = -100;
    double max = 100;
    double range = max - min;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double sample = rnd.NextDouble();
            double scaled = (sample * range) + min;
            array[i, j] = Math.Round((float)scaled, 2);
        }
    }
}

void PrintArray(double[,] array)
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