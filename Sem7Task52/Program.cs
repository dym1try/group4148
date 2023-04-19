// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//* Дополнительно диагональ выделить разным цветом.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4       Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод заполнение массива
int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
{

    //Защита от дурака
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(but, top + 1);
        }

    }
    return arr;
}


//Метод печати 2мерного массива 
void Print2Darray(int[,] arr)
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

double SumCol2Darray(int[,] arr)
{
    int sum = 0;
    double middle = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i, j];
    }
    middle = sum / (i + 1);
    Console.WriteLine("Среднее арифметическое" + (j) + "-го столбца: " + middle);
    return middle;
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr = Gen2DArray(row, col, 10, 99);
Print2Darray(arr);
SumCol2Darray(arr);
