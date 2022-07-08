// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет / 23432 -> да / 12821 -> да
Console.WriteLine($"Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
if (number < 10000 || number > 99999)
{
    Console.WriteLine($"Число {number} не пятизначное.");
}
else
{
    Console.WriteLine(IsPalindrome(stringNumber));
}

bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;
}