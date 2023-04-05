// Задача №18
// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// печатаем тест четверти
void PrintCoordTest(int quater)
{
    if (quater == 1) Console.WriteLine("x > 0 , y > 0");
    if (quater == 2) Console.WriteLine("x > 0 , y < 0");
    if (quater == 3) Console.WriteLine("x < 0 , y < 0");
    if (quater == 4) Console.WriteLine("x < 0 , y > 0");
}

int quaterINT = ReadData("Введите Номер Четверти: ");


PrintCoordTest(quaterINT);