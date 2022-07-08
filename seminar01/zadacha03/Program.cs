// Принимает число N и показывает все числа от -N до N
int numberN = EnterData("Введите число: ");
int numberM = numberN * - 1;
for (int i = numberM; i <= numberN; i++)
{
    Console.Write(i + " ");
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}