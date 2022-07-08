// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int sideOne = EnterData("первой");
int sideTwo = EnterData("второй");
int sideThree = EnterData("третьей");
if (sideOne + sideTwo > sideThree &&
    sideOne + sideThree > sideTwo &&
    sideTwo + sideThree > sideOne)
{
    Console.WriteLine("Треугольник с заданными сторонами возможен.");
}
else Console.WriteLine("Треугольник с заданными сторонами невозможен.");

int EnterData(string text)
{
    Console.WriteLine($"Введите размер {text} стороны.");
    return Convert.ToInt32(Console.ReadLine());
}