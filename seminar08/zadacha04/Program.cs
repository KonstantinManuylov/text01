// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int lines = EnterData("строк");
int columns = EnterData("столбцов");
int[,] numbers = GetArray(lines, columns);
PrintArray(numbers, "Базовый");
int minValue = numbers[0, 0];
int minLineIndex = 0;
int minColumnIndex = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (minValue > numbers[i, j])
        {
            minValue = numbers[i, j];
            minLineIndex = i;
            minColumnIndex = j;
        }
    }
}
Console.WriteLine($"Минимальное значение {minValue} находится в позиции: строка - {minLineIndex + 1}, столбец - {minColumnIndex + 1}. ");
int[,] numbersLineOut = DeleteLine(numbers, minLineIndex);
int[,] numbersColumnOut = DeleteColumn(numbersLineOut, minColumnIndex);
PrintArray(numbersColumnOut, "Измененный");

int[,] DeleteLine(int[,] array, int line)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1)];
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == line)
        {
            line = -1;
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[x, j] = array[i, j];
        }
        x++;
    }
    return result;
}

int[,] DeleteColumn(int[,] array, int col)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int x = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == col)
                continue;
            result[i, x] = array[i, j];
            x++;
        }
    }
    return result;
}

int[,] GetArray(int l, int c)
{
    int[,] array = new int[l, c];
    FillArray(array);
    return array;
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
    Console.WriteLine($"Введите количество {text}: ");
    return Convert.ToInt32(Console.ReadLine());
}