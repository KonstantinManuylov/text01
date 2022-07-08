// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 / 78 -> 2 / 89126 -> 5
Console.WriteLine($"Введите число: ");
string? number = Console.ReadLine();
int count = 0;
while (count < number.Length)
{
    count++;
}
Console.WriteLine($"В числе {number} {count} цифр(ы). ");