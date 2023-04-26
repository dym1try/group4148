// ДЗ. Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Рекур.метод
int SumDigRec(int m, int n)
{
    if (m < n) return m + SumDigRec(m + 1, n);
    else return m;
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
// (m < n) ? SumDigRec(m, n) : SumDigRec(n, m); // ?: не понимаю, почему эта строка не работает(
if (m > n)// Защита от дурака - первоначальный простой метод
{
    int buf = m;
    m = n;
    n = buf;
}

Console.Write(SumDigRec(m, n));