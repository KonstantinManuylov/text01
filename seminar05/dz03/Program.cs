// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine($"Введите количество чисел");
int amount = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[amount];
FillArray(numbers);
PrintArray(numbers);
int difference = DifferenceNumbers(numbers);
Console.WriteLine($"Разница максимального и минимального числа массива: {difference}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine($"Базовый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int DifferenceNumbers(int[] array)
{
    int min = int.MaxValue;
    int max = int.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}