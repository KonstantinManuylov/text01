// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine($"Введите количество необходимых чисел: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[amount];
FillArray(numbers);
PrintArray(numbers);
EvenNumbers(numbers);

void EvenNumbers(int[] array)
{
    Console.WriteLine($"Четные числа: ");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.Write($"{array[i]}, ");
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Четных чисел {count}.");
}
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine($"Базовый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}