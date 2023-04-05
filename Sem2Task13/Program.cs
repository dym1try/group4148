﻿// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string


Console.WriteLine("Введите (целое положительное*) число длиной до 10 цифр: ");
long num = int.Parse(Console.ReadLine() ?? "0");

// Задаем переменную third
long third = -1;
// 
if (num < 100)
{
 Console.Write("В Вашем числе нет третьей цифры.");
}
else
{
    if (num >= 100 && num <= 999) third = num % 10; // для 3-значных чисел

    if (num >= 1000 && num <= 9999) third = (num % 100 - num % 10) / 10; // для 4-значных чисел

    if (num >= 10000 && num <= 99999) third = (num % 1000 - num % 100) / 100; // для 5-значных чисел

    if (num >= 100000 && num <= 999999) third = (num % 10000 - num % 1000) / 1000; // для 6-значных чисел

    if (num >= 1000000 && num <= 9999999) third = (num % 100000 - num % 10000) / 10000; // для 7-значных чисел

    if (num >= 10000000 && num <= 99999999) third = (num % 1000000 - num % 100000) / 100000; // для 8-значных чисел

    if (num >= 100000000 && num <= 999999999) third = (num % 10000000 - num % 1000000) / 1000000; // для 9-значных чисел
    
    if (num >= 1000000000 && num <= 9999999999) third = (num % 100000000 - num % 10000000) / 10000000; // для 10-значных чисел

    Console.Write("Третья цифра числа: " + third);
}