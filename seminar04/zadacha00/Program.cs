// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28 / 4 -> 10 / 8 -> 36

Console.WriteLine($"Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (numberN > 0)
{
    sum += numberN;
    numberN--;
}
Console.WriteLine(sum);