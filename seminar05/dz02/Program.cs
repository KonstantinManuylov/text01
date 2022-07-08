// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 / [-4, -6, 89, 6] -> 0

Console.WriteLine($"Введите необходиме количество чисел: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[amount];
FillArray(numbers);
PrintArray(numbers);
int sum = SumOddIndex(numbers);
Console.WriteLine("");
Console.WriteLine($"Сумма значений в нечетных позициях: {sum}.");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine($"Базовый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}