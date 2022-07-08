Console.WriteLine($"Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= numberN; i++)
{
    Console.Write($"{i * i * i} / ");
}