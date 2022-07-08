// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 / 5 -> 120
Console.WriteLine($"Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int product = Product(numberN);
Console.WriteLine(product);

int Product(int number)
{
    int count = 1;
    for (int i = 2; i <= number; i++)
    {
        count *= i;
    }
    return count;
}