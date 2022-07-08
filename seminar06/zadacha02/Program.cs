// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 / 3  -> 11 / 2  -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int systemNumber = 2;
int binSize = 0;
int tempNumber = number;
while (tempNumber != 0)
{
    tempNumber /= systemNumber;
    binSize++;
}
int[] binArray = new int[binSize];
tempNumber = number;
for (int i = binArray.Length - 1; i >= 0; i--)
{
    binArray[i] = tempNumber % systemNumber;
    tempNumber /= systemNumber;
}
Console.Write($"Число {number} в двоичной системе: ");
PrintArray(binArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}