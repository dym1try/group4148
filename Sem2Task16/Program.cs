// Задача №16
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число квадратом другого. 

Console.WriteLine("Введите первое число: ");
// Более БЫСТРЫЙ метод проверки непустого ввода
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

void SqrtTest(int a, int b)
{
    if (a == b * b)
        Console.WriteLine(a + " это квадрат " + b);
    else
        Console.WriteLine(a + " это не квадрат " + b);
}
SqrtTest(num1, num2);
SqrtTest(num2, num1);