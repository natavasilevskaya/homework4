﻿// Программа принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigit (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

    
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of digit is " + SumOfDigit(number));