// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3 / [6 7 3 6] -> 36 21

Console.WriteLine($"Введите количество чисел: ");
int numbersAmount = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[numbersAmount];
FillArray(numbers);
PrintArray(numbers, "Базовый массив: ");
int newNumberAmount = NewArrayAmount(numbersAmount);
int[] newArray = Multiplication(numbers, newNumberAmount);
PrintArray(newArray, "Измененный массив: ");


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
}
void PrintArray(int[] array, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int NewArrayAmount(int number)
{
    newNumberAmount = 0;
    if (numbersAmount / 2 != 0)
    {
        newNumberAmount = numbersAmount / 2 + 1;
    }
    else newNumberAmount = numbersAmount / 2;
    return newNumberAmount;
}
int[] Multiplication(int[] array, int index)
{
    int[] multiplicatedNumbers = new int[index];
    for (int i = 0; i < index; i++)
    {
        multiplicatedNumbers[i] = array[i] * array[index - (1 + i)];
    }
    if (index % 2 != 0)
    {
        multiplicatedNumbers[index - 1] = array[index - 1];
    }
    return multiplicatedNumbers;
}