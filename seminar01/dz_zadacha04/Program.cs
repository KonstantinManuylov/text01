// вход 3 числа, отдает максимальное.
int numberOne = EnterData("Введите первое число: ");
int numberTwo = EnterData("Введите второе число: ");
int numberThree = EnterData("Введите третье число: ");
if (numberOne > numberTwo && numberOne > numberThree)
{
    Console.WriteLine($"Число {numberOne} максимальное");
}
else if (numberTwo > numberOne && numberTwo > numberThree)
{
    Console.WriteLine($"Число {numberTwo} максимальное");
}
else Console.WriteLine($"Число {numberThree} максимальное");

int EnterData(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}