// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int number1;
int number2;

Console.Write("Введите первое число: ");
number1 = Convert.ToInt32(Console.ReadLine()); // Добавила Convert.ToInt32 так как Console.ReadLine() не сможет сравнить тип данных string 
Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine());


if (number1 > number2)
{
Console.WriteLine("Число "+ number1 +" больше");
Console.WriteLine("Число "+ number2 +" меньше");
}
else
{
    Console.WriteLine("Число "+ number2 +" больше");
    Console.WriteLine("Число "+ number1 +" меньше");
}



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
/*
int number1;
int number2;
int number3;

Console.Write("Введите первое число: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
number3 = Convert.ToInt32(Console.ReadLine());

int numberMax=number1;

if ( number2 > numberMax)
{
    numberMax=number2;
}
if ( number3 > numberMax)
{
    numberMax=number3;
}

Console.Write("Максимальное число: "+ numberMax);
*/