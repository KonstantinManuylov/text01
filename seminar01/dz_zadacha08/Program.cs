// на входе N, выход четные числа от 1 до N
int numberN = EnterData("Введите число: ");
for (int i = 1; i <= numberN; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}