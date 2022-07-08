// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 / Если N = 3 -> 0 1 1 / Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int first = 0;
int second = 1;
if (number == 1)
{
    Console.Write(first);
}
else if (number == 2)
{
    Console.Write($"{first} {second}");
}
else if (number > 2)
{
    Console.Write($"{first} {second} ");
    for (int i = 2; i < number; i++)
    {
        sum = first + second;
        first = second;
        second = sum;
        Console.Write(sum + " ");
    }
}


