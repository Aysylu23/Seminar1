/*Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое число меньшее*/
Console.Write("Введите первое число: ");
string? input1 =  Console.ReadLine();
int firstNumber = Convert.ToInt32(input1);

Console.Write("Введите второе число: ");
string? input2 =  Console.ReadLine();
int secondNumber = Convert.ToInt32(input2);


if(firstNumber > secondNumber)
{
    Console.WriteLine("Максимальное число равно: " + firstNumber);
    Console.WriteLine("Минимальное число равно: " + secondNumber);
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine("Максимальное число равно: " + secondNumber);
    Console.WriteLine("Минимальное число равно: " + firstNumber);
}

else 
{
   Console.WriteLine("Числа равны");

}
