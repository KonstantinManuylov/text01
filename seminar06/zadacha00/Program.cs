// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1] / [6 7 3 6] -> [6 3 7 6]


int[] array = GetArray(5);
PrintArray(array, "Базовый массив: ");
for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i]; // -1 потому что размер будет на 1 больше, 
    // чем индекс последнего элемента. -i потому что идем с последнего элемента массива.
    array[array.Length - 1 - i] = temp;
}
PrintArray(array, "Перевернутый массив: ");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] array, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] GetArray(int length) // метод для получения массива, на основе метода FillArray.
{
    int[] newArray = new int [length];
    FillArray(newArray);
    return newArray;
}