﻿// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ввведите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("ответ - max " + numberA);
}
else if (numberA < numberB)
{
    Console.WriteLine("ответ - max " + numberB);
}
else
{
    Console.WriteLine("максимального нет, так как оба числа равны");
}