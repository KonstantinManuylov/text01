// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int lineAmount = EnterData("Введите количество строк массива: ");
int columnAmount = EnterData("Введите количество столбцов массива: ");
int[,] baseArray = new int[lineAmount, columnAmount];
FillArray(baseArray);
Console.WriteLine("Исходный массив ");
PrintArray(baseArray);

Console.WriteLine("Сортировка по убыванию");
int[] line = new int[columnAmount];

for (int i = 0; i < lineAmount; i++)
{
    for (int j = 0; j < columnAmount; j++)
    {
        line[j] = baseArray[i, j];
    }
    Sort(line);
    Insert(i, line, baseArray);
}
PrintArray(baseArray);

void Insert(int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        dest[dim, k] = source[k];
    }
}

void Sort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
    }
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

void PrintArray(int[,] array)
{
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
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}