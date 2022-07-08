// Напишите программу замена элементов массива: положительные элементы замените
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int numbersAmount = 10;
int[] numbers = new int[numbersAmount];
FillArray(numbers);
PrintArray(numbers, "Базовый массив: ");
string Empty;
Change(numbers);
PrintArray(numbers, "Измененный массив: ");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}
void PrintArray(int[] array, string text)
{
    Console.Write(text);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void Change(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}