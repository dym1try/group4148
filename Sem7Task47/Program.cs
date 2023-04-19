// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генератор 2-мерного массива ВЕЩЕСТВЕННЫХ чисел - кол-во строк, столбцов, верх, низ

double[,] GenReal2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().NextDouble() * 200 - 100; // Задал диапазон от -100 до 100
        }
    }
    return arr;
}
// Метод печати 2 мерного массива + случайная раскраска
void Print2DArray(double[,] arr)// ИСПРАВЛЕН ТИП НА DOUBLE
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};// библиотека цветов
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];//выбор случайного цвета
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();//сброс цвета
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
double[,] arr2D = GenReal2DArray(row, col, 10, 99);
Print2DArray(arr2D);