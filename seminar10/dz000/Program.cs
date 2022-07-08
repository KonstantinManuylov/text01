Console.WriteLine("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
// int M  = 50;
/* for (int i = 1; i <= N; i++)
{
    Console.Write(i + " ");
} */


int[] numbers = new int[N];
FillArra(numbers);
PrintArray(numbers);

void FillArra(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i + 1;
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}