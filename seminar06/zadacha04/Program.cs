// Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

Console.WriteLine($"Введите количество чисел в массиве: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] baseArray = new int[amount];
int[] copyArray = new int[amount];
FillArray(baseArray);
PrintArray(baseArray, "Базовый");
for (int i = 0; i < baseArray.Length; i++)
{
    copyArray[i] = baseArray[i];
}
PrintArray(copyArray, "Копия");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}
void PrintArray(int[] array, string text)
{
    Console.WriteLine($"{text} массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}