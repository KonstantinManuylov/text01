// вход - двухначное число. вывод - показывает большее число.
int number = new Random().Next(10, 100);
int first = number / 10;
int second = number % 10;
Console.WriteLine($"Базовое число {number}.");
int max = MaxNumber(first, second);
Console.WriteLine($"Число {max} больше.");

int MaxNumber(int number1, int number2)
{
    if (number1 > number2)
    {
        return number1;
    }
    return number2;
}