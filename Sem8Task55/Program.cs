// Задача №55 Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //задаём двумерный массив, для этого вводим запятую: " [,] "
// int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
// {
//     if (but > top)
//     {
//         int buf = top;
//         top = but;
//         but = buf;
//     }
//     int[,] res = new int[countRow, countColumn];

//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             res[i, j] = new Random().Next(but, top + 1);
//         }
//     }
//     return res;
// }

// //Метод печати 2 мерного массива 
// void Print2DArray(int[,] arr)
// {

//     for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// //Метод замены строк на столбцы
// int[,] StringReplacement(int[,] arr)
// {
//     int count =0;
//     int[,] res = new int[arr.GetLength(0),arr.GetLength(1)];
//     for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки(0)/столбца(1)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             res[i,j] = arr[j,i];
//             count++;
//         }
//     }
//     Console.WriteLine(count);
//     return res;
// }
// void TransposeArray(int[,] arr)
// {
//     int count = 0;
//     int temp = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < arr.GetLength(1); j++)
//         {
//             temp = arr[i, j];
//             arr[i, j] = arr[j, i];
//             arr[j, i] = temp;
//             count++;
//         }
//     }
//      Console.WriteLine(count);
// }

// int row = ReadData("Введите кол-во строк: ");
// int col = ReadData("Введите кол-во столбцов: ");
// int[,] arr2D = Gen2DArray(row, col, 10, 99);
// Print2DArray(arr2D);
// int[,] res = StringReplacement(arr2D);
// TransposeArray(arr2D);

// Console.WriteLine("========================================");
// Print2DArray(res);
// Console.WriteLine("========================================");
// Print2DArray(arr2D);


Console.Clear();
//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод генерации массива
int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
{
    if (but > top)
    {
        int buf = top;
        top = but;
        but = buf;
    }
    int[,] res = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            res[i, j] = new Random().Next(but, top + 1);
        }
    }
    return res;
}

//Метод печати одномерного массива 
void Print2Darray(int [,] arr)
{   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    
}

//проверка массива на симметричность

//Из строк в столбцы
int[,] FromRowToColumn(int [,] arr)
{
    int[,] InMatrix = new int[arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            InMatrix[i,j] = arr[j,i];
        }
    }
    return InMatrix;
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: "); 
int[,] arr = Gen2DArray(m,n,100,0);
Print2Darray(arr);
arr = FromRowToColumn(arr);
Print2Darray(arr);