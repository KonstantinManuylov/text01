// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] => положтельные = 29, отрицательные = -20

int[] numbers = new int[12];
FillArray(numbers);
PrintArray(numbers);
int sumNegative = SumNegative(numbers);
Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}");
string Empty;
int sumPositive = SumPositive(numbers);
Console.WriteLine($"Сумма положительных чисел: {sumPositive}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine($"Базовый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int SumNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
int SumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}