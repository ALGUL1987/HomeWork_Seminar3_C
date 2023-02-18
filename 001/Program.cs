/*
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
int number;
bool isNum = int.TryParse(num, out number);
if (number > 9999 && number < 100000)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Введенное число {num} является палиндромом");
    }
    else
    Console.WriteLine($"Введенное число {num} НЕ является палиндромом");
}
else
Console.WriteLine($"Введенное число {num} НЕ является пятизначным");