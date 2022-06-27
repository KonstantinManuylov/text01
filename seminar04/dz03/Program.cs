// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Вывод сделать отдельным методом.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] / 6, 1, 33 -> [6, 1, 33]
// на семинаре дал добро на заволнение массива рандомными числами. 
// В оригинале нужно пользователю ввести строку - ряд чисел через запятую, 
// а программа превращает эту строку в полноценный массив и выводит.

int[] numbers = new int[8];
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Введите число {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
PrintArray(numbers);

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");
        }
        else Console.Write($"{array[i]}, ");
    }
}