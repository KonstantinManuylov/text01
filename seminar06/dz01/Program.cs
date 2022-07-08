// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 / -1, -7, 567, 89, 223-> 3

Console.WriteLine($"Введите желаемое количество чисел: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[amount];
int count = 0;
// PrintArray(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Введите число {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Всего чисел больше 0: {count}");

void PrintArray(int[] array)
{
    Console.WriteLine($"Базовый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}