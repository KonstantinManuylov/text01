// Написать программу, которая по номеру будет выдавать название дня недели по заданному номеру
int day = EnterData("Введите число от 1 до 7");
if (day < 1 || day > 7)
{
    Console.WriteLine("Такого дня не существует.");
}
else if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
}
else if (day == 3)
{
    Console.WriteLine("Среда");
}
else if (day == 4)
{
    Console.WriteLine("Четверг");
}
else if (day == 5)
{
    Console.WriteLine("Пятница");
}
else if (day == 6)
{
    Console.WriteLine("Суббота");
}
else if (day == 7)
{
    Console.WriteLine("Воскресенье");
}

int EnterData (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}