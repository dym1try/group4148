// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));
    return res;
}

//метод генерации массива
int[,] Gen2DArray(int countRow, int countColum, int minValue, int maxValue)

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

//Метод умножения элементов двух массивов
int[,] ProdArray(int[,] arr1, int[,] arr2)
{
    int[,] arrOut = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arrOut[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
    return arrOut;
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: "); 
int[,] arr1 = Gen2DArray(m, n, 0, 100);
int[,] arr2 = Gen2DArray(m, n, 0, 100);
Console.WriteLine("Первый массив:");
Print2DArray(arr1);
Console.WriteLine("Второй массив:");
Print2DArray(arr2);
// ProdArray(arr1, arr2);
int[,] arrOut = ProdArray(arr1, arr2);

Console.WriteLine("Массив произведений:");
Print2DArray(arrOut);
