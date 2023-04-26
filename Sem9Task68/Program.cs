// ДЗ. Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

int Akkerman(int m, int n)
{
if(m == 0)
	{
		return n + 1;
	}
	if(m > 0 && n == 0)
	{
		return Akkerman(m - 1, 1);
	}
	return Akkerman(m - 1, Akkerman(m, n - 1));

}
int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

Console.Write(Akkerman(m, n));