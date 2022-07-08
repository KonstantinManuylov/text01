// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double b1 = EnterData("b1");
double k1 = EnterData("k1");
double b2 = EnterData("b2");
double k2 = EnterData("k2");
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Прямые пересекаются в точке: ({x}; {y})");
    Console.WriteLine();
    Console.WriteLine("Нажмите Enter для выода из программы.");
    Console.ReadLine();
}

double EnterData(string numbers)
{
    Console.Write($"Число {numbers} = ");
    return Convert.ToDouble(Console.ReadLine());
}