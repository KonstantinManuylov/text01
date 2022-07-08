int coordinateX = EnterData("Введите координату X: ");
int coordinateY = EnterData("Введите координату Y: ");
if (coordinateX > 0 && coordinateY > 0)
{
    Console.WriteLine($"Заданная точка находится в первой четверти.");
}
else if (coordinateX < 0 && coordinateY > 0)
{
    Console.WriteLine($"Заданная точка находится во второй четверти.");
}
else if (coordinateX < 0 && coordinateY < 0)
{
    Console.WriteLine($"Заданная точка находится в третьей четверти.");
}
else if (coordinateX > 0 && coordinateY < 0)
{
    Console.WriteLine($"Заданная точка находится в четвертой четверти.");
}
else Console.WriteLine($"Значение не может быть нулевым.");

int EnterData(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}