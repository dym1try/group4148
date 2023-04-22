// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));
    return res;
}

//метод генерации массива
int[,] Gen2Darray(int countRow, int countColum, int minValue, int maxValue)

{
    int[,] arr = new int[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}


//метод печати двумерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int MinSumRaw(int[,] arr)// метод нахождения строки с минимальной суммой элементов
{
    int outN = -1;
    int sum = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)// идем по строчкам
    {
        int sumRaw = 0;
        for (int j = 0; j < arr.GetLength(1); j++)// идем по столбцам
        {
            {
                sumRaw = sumRaw + arr[i, j];
                {
                    if (sumRaw < sum)
                    {
                        sum = sumRaw;
                        outN = i;
                    }
                }
            }
        }
    }
    return outN;
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2Darray(row, col, 10, 99);
Print2DArray(arr2D);
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + MinSumRaw(arr2D));