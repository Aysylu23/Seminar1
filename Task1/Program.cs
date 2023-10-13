

//int - целое число
//string - строка
//double - число с плавающей строкой
//bool - правда/ложь

//int number = 4;
//Console.WriteLine(number);

//Console.ReadLine();
//Console.WriteLine();
//Console.Write();

//if - условие
//if (number > 5)
//{
//    Console.WriteLine(number);
//}
//Console.WriteLine("Нет");

//if (number < 5)
//{
   // Console.WriteLine(number);
//}
//else 
//{
  // Console.WriteLine("Нет");
//}


//int number1 = 4;
//int number2 = 6;

//Console.WriteLine(number1 / number2);

//string name = "Denis";
//string age = "24";
//Console.WriteLine(name + "" + age);

/*Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
на само себя).

Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/

/*Console.Write("Введите число");
string? input = Console.ReadLine();
int number = Convert.ToInt32(input);
int sqrtNumber = number * number;

Console.Write("Число" + number + "в квадрате равно:");
Console.WriteLine(sqrtNumber);*/




/*Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет*/
Console.Write("Введите первое число: ");
string? input1 =  Console.ReadLine();
int firstNumber = Convert.ToInt32(input1);

Console.Write("Введите второе число: ");
string? input2 =  Console.ReadLine();
int secondNumber = Convert.ToInt32(input2);

int sqrtNumber = secondNumber * secondNumber;


if(sqrtNumber == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}