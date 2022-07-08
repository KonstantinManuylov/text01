// вход 2 числа, программа показывает которое больше, а которое меньше
int numberN = EnterData("Введите первое число: ");
int numberM = EnterData("Введите второе число: ");
if (numberN > numberM)
    Console.WriteLine($"Число {numberN} больше чем {numberM}.");
else Console.WriteLine($"Число {numberM} больше чем {numberN}.");

int EnterData(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}