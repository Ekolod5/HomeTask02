﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.;
// 456 -> 5;
// 782 -> 8;
// 918 -> 1;

Console.WriteLine("Введите трехзначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = number1 / 10 % 10;
if (number1 < 100 || number1 > 999) 
{
    Console.WriteLine("Не трехзначное число");
}
else
{
    Console.WriteLine($"Вторая цифра равна: {number2}");
}