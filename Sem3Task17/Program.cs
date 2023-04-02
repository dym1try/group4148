// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Метод, который вернет нам значение переменной, 
// читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


void PrintQuoterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в 1 четверти.");
    if (x > 0 && y < 0) Console.WriteLine("Точка в 2 четверти.");
    if (x < 0 && y < 0) Console.WriteLine("Точка в 3 четверти.");
    if (x < 0 && y > 0) Console.WriteLine("Точка в 4 четверти.");

}

int coordX = ReadData("Введите координату X");
int coordY = ReadData("Введите координату Y");
PrintQuoterTest(coordX,coordY);
