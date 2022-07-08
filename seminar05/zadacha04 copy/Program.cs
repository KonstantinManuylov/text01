Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];

Fillrray(array);
WriteArray(array);

int newSizeArray = 0;
if (sizeArray % 2 == 0)
{
    newSizeArray = sizeArray / 2;
}
else
{
    newSizeArray = (sizeArray / 2) + 1;
} // создание размера массива, индекса, для нового массива - ГОТОВО (метод)

int[] newArray = new int[newSizeArray]; // создание нового массива для записи результата
for(int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i] * array[array.Length - (1 + i)];
} // проход по массиву и перемножение значений

if (sizeArray % 2 != 0)
{
    newArray[newArray.Length - 1] = array[newArray.Length -1];
} // печать значения, если нечетное количество индексов. Последнее значение с конца, индекс уменьшенный.

WriteArray(newArray); // вызов печати нового массива

void Fillrray(int[] array)   // Запонение массива - ГОТОВО (метод)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}
void WriteArray(int[] array)  // печать массива - ГОТОВО (метод)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}