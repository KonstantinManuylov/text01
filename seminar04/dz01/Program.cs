// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) / 2, 4 -> 16

int baseNumber = EnterData("базовое число");
int powerNumber = EnterData("степень");
int power = baseNumber;
for (int i = 1; i < powerNumber; i++)
{
    power = power * baseNumber;
}
Console.WriteLine($"Число {baseNumber} в степени {powerNumber} равно {power}.");

int EnterData(string text)
{
    Console.WriteLine($"Введите {text}.");
    return Convert.ToInt32(Console.ReadLine());
}