// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46. 782 -> 72. 918 -> 98

Random rnd = new Random();
int number = rnd.Next(100, 1000);
Console.WriteLine($"Число: {number}");
string stringNumber = Convert.ToString(number);
Console.WriteLine($"{stringNumber[0]}{stringNumber[2]}");