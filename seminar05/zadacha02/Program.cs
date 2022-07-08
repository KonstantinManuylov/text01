// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[10];
FillArray(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == number)
    {
        Console.WriteLine($"Число {number} находится в массиве.");
        break;
    }
    else if (i == numbers.Length - 1)
    {
        Console.WriteLine($"Число {number} не находится в массиве.");
    }
}
PrintArray(numbers);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
}
void PrintArray(int[] array)
{
    Console.Write($"Базовый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}