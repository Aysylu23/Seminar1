/*Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое число меньшее*/
Console.Write("Введите первое число: ");
string? input1 =  Console.ReadLine();
int firstNumber = Convert.ToInt32(input1);

Console.Write("Введите второе число: ");
string? input2 =  Console.ReadLine();
int secondNumber = Convert.ToInt32(input2);


if(firstNumber > secondNumber)
{
    Console.WriteLine("max" + firstNumber);
}
else
{
    Console.WriteLine("max" + secondNumber);
}
if(firstNumber < secondNumber)
{
    Console.WriteLine("min" + firstNumber);
}
else
{
    Console.WriteLine("min" + secondNumber);
}