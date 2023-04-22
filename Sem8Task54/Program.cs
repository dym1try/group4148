// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void SortArr(int[,] arr)
{
    int[] buf = new int[arr.GetLength(1)];// вводим новый буферный 1-мерный массив
    for (int i = 0; i < arr.GetLength(0); i++)// идем по строчкам
    {
        for (int j = 0; j < arr.GetLength(1); j++)// идем по столбцам
        {
            buf[j] = arr[i, j];
        }
        // сортировка вставкой

        for (int k = 1; k < arr.GetLength(1); k++)
        {
            int sorted = k - 1;
            while (sorted > -1 && buf[sorted] > buf[sorted + 1])
            {
                int temp = buf[sorted];
                buf[sorted] = buf[sorted + 1];
                buf[sorted + 1] = temp;
                sorted--;
            }
        }
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = buf[j];
    }
}
int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2Darray(row, col, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
SortArr(arr2D);
Print2DArray(arr2D);