/*Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел*/
Console.Write("Введите первое число: ");
string? input1 =  Console.ReadLine();
int firstNumber = Convert.ToInt32(input1);

Console.Write("Введите второе число: ");
string? input2 =  Console.ReadLine();
int secondNumber = Convert.ToInt32(input2);

Console.Write("Введите третье число: ");
string? input3 =  Console.ReadLine();
int thirdNumber = Convert.ToInt32(input3);


if (firstNumber > secondNumber)
{ 
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число равно:" + firstNumber);
    }
}

if (secondNumber > firstNumber)
{ 
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число равно:" + secondNumber);
    }
}

if (thirdNumber > secondNumber)
{ 
    if (thirdNumber > firstNumber)
    {
        Console.WriteLine("Максимальное число равно:" + thirdNumber);
    }  
}

if (thirdNumber == secondNumber)
{ 
    if (thirdNumber == firstNumber)
    {
        Console.WriteLine("Числа равны");
    }
}

