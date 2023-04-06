// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

Console.WriteLine("Введите число: "); // Считываем данные с консоли
int num = int.Parse(Console.ReadLine()??"0");

int startNum = 1; // задаем первое число в ряду
string res = string.Empty; // создаем пустую строку для ряда просто значений
while (startNum <= num)
    {
        res = res + startNum + " ";
        startNum = startNum + 1;
    }

Console.WriteLine(res);

string resKub = string.Empty; // создаем пустую строку для ряда кубов
int startNum3 = 1; // снова задаем первое число в ряду 
while (startNum3 <= num)
    {
        resKub = resKub + Math.Pow(startNum3, 3) + " ";
        startNum3 = startNum3 + 1;
    }

Console.WriteLine(resKub);