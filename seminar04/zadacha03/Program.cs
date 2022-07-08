// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int numbersAmount = 8;
int[] array = new int[numbersAmount];
FillArray(array);
PrintArray(array);

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] a)
{
    Console.Write($"[");
    for (int i = 0; i < a.Length; i++)
    {
        if (i == a.Length - 1)
        {
            Console.Write(a[i]);
        }
        else Console.Write(a[i] + ", ");
    }
    Console.Write($"]");
}