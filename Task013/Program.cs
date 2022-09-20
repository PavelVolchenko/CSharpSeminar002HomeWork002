/*      Задача 13: Напишите программу, которая выводит третью цифру 
        заданного числа или сообщает, что третьей цифры нет.
        645 -> 5
        78 -> третьей цифры нет
        32679 -> 6                                               */

int ShowThirdDigitInNumber(int number)
{
    while(number > 1000)
    {
        number /= 10;
    }
    number %= 10;
    return number;
}

int CheckTripleDigits(int number)
{
    if(number > 99) return ShowThirdDigitInNumber(number);
    else return -1;
}

int number = new Random().Next(-99, 10000000);
Console.WriteLine($"Входное число: {number}");

if(CheckTripleDigits(number) == -1) 
{
    Console.WriteLine("Третьей цифры нет!");
}
else Console.WriteLine($"Третья цифра: {CheckTripleDigits(number)}");

