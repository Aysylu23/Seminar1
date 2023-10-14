/*Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли число на 2 без остатка) */

Console.Write("Введите число: ");
string? input =  Console.ReadLine();
int number = Convert.ToInt32(input);


if (number % 2 == 0) 
{
    Console.WriteLine("Четное число");
}
else 
{
     Console.WriteLine("Нечетное число");
}