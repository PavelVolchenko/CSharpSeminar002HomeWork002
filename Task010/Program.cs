/*
Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int ShowSecondDigitInNumber(int number)
{
    number /= 10;
    number %= 10;
    return number;
}

int number = new Random().Next(100, 1000);
int secondDigit = ShowSecondDigitInNumber(number);
Console.WriteLine($"Входное число: {number}");
Console.WriteLine($"Вторая цифра входного числа: {secondDigit}");