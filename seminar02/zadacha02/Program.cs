// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
int firstNumber = EnterData("Введите первое число: ");
int secondNumber = EnterData("Введите второе число: ");
if (firstNumber % secondNumber != 0)
{
    int leftNumber = firstNumber % secondNumber;
    Console.WriteLine($"Не кратно, отсаток {leftNumber}.");
}
else Console.WriteLine($"Кратно.");

int EnterData (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}