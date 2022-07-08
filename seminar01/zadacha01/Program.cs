// 2 числа на вход, проверка является ли первое число квадратом второго
int numberA = EnterData("Введите первое число:");
int numberB = EnterData("Введите второе число:");
if (numberB != numberA * numberA)
{
    Console.WriteLine($"Число {numberA} не является квадратом {numberB}.");
}
else
{
    Console.WriteLine($"Число {numberA} является квадратом {numberB}.");
}

int EnterData (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}