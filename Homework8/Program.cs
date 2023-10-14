/*Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N*/

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int chNumber = 2;

while (chNumber <= n)
{
    Console.Write(chNumber + " ");
    chNumber += 2;
}
