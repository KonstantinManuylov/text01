// На вход трехзначное число. На выход только последняя цифра.
int numberN = EnterData("Введите трехзначное число: ");
int numberM = numberN % 10;
if (numberN < 100 || numberN > 999)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    Console.WriteLine(numberM);
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}