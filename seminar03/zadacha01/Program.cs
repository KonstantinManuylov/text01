// вход от 1 до 4, выход - диапазон возможных координат в заданной четверти.
Console.WriteLine($"Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
int max = int.MaxValue;
int min = int.MinValue;

if (quarter == 1)
{
    Console.WriteLine($"Возможные координаты X = {max}; Y = {max}.");
}
else if (quarter == 2)
{
    Console.WriteLine($"Возможные координаты X = {min}; Y = {max}.");
}
else if (quarter == 3)
{
    Console.WriteLine($"Возможные координаты X = {min}; Y = {min}.");
}
else if (quarter == 4)
{
    Console.WriteLine($"Возможные координаты X = {max}; Y = {min}.");
}
else Console.WriteLine($"Такой четверти нет.");