﻿// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1 


Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int scndNum = (num%100 - num%10) / 10; // Вычитаем остатки от деления друг из друга и делим их на 10.

Console.WriteLine("Ваше число: " + num);
Console.WriteLine("Вторая цифра: " + scndNum);
