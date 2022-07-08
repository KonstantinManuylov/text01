// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1 / [1, 2, 3, 6, 2] -> 0 / [10, 11, 12, 13, 14] -> 5

int[] numbers = new int[123];
FillArray(numbers);
PrintArray(numbers);
string Empty;
PrintRangeArray(numbers);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write($"Базовый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}
void PrintRangeArray(int[] array)
{
    Console.Write($"Новый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        Console.Write(array[i] + " ");
    }
}