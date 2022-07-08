// вход число N. выход - квадраты чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25; 2 -> 1, 4;

Console.WriteLine($"Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= numberN; i++)
{
    Console.Write($"{i * i} / ");
}