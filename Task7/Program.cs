﻿/* Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
    if(number < 1000)
    {
        int result = number % 10;
        Console.WriteLine(result);
    }
}
