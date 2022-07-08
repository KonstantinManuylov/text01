// Число, ответ, четное или нечетное
Random rnd = new Random();
int number = rnd.Next(1, 1001);
if (number % 2 != 0)
{
    Console.WriteLine($"Число {number} нечетное.");
}
else Console.WriteLine($"Число {number} четное.");