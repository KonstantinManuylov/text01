// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5. 78 -> третьей цифры нет. 32679 -> 6

Console.WriteLine($"Введите число: ");
string? number = Console.ReadLine();
if (number.Length < 3)
{
    Console.WriteLine($"В числе {number} нет третьего знака.");
}
else Console.WriteLine($"{number[2]}");