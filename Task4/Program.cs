/*Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
на само себя).

Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/

Console.Write("Введите число: ");
string? input =  Console.ReadLine();
int number = Convert.ToInt32(input);

int sqrtNumber = number * number;

Console.Write("Число " + number + " в квадрате равно: ");
Console.WriteLine(sqrtNumber);