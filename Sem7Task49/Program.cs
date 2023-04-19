// Задача №4 Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и 
// замените эти элементы на их квадраты. Например:
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// Console.Clear();

// //Метод ввода 
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Метод заполнение массива
// int[,] Gen2DArray(int countRow,int countColumn, int but, int top)
// {

//     //Защита от дурака
//     int[,] arr = new int[countRow,countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countRow; j++)
//     {
//         arr[i,j] = new Random().Next(but, top + 1); 
//     }

//     }
//     return arr;
// }

// //Метод печати одномерного массива 
// void Print2Darray(int [,] arr)
// {   
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {   
//             if(arr[i,j] % 2 == 0)
//             {
//             Console.ForegroundColor = col[new Random().Next(0,1)];
//             Console.Write(arr[i,j] + " ");
//             Console.ResetColor();
//             }
//             if(arr[i,j] % 2 != 0)
//             {
//             Console.ForegroundColor = col[new Random().Next(2,3)];
//             Console.Write(arr[i,j] + " ");
//             Console.ResetColor();
//             }
//         }
//         Console.WriteLine();
//     }

// }
// int[,] FillNM2DArray(int [,] arr)
// {   

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = i + j;
//         }

//     }
//     return arr;
// }

// int row = ReadData ("Введите колличество строк: ");
// int col = ReadData ("Введите колличество столбцов: ");
// int [,] arr2D = Gen2DArray (row,col,10,99);
// int [,] arr = FillNM2DArray(arr2D);
// Print2Darray(arr);

//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//задаём двумерный массив, для этого вводим запятую: " [,] "
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


int[,] SquareOfEvenIndices(int[,] arr)
{
    int[,] outArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                outArr[i, j] = arr[i, j] * arr[i, j];
            }
            else
            {
                outArr[i, j] = arr[i, j];
            }
        }
    }
    return outArr;
}

void FillArrayMod2Square(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr.GetLength(1); j = j + 2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
}

//Метод печати 2 мерного массива 
void Print2DArray(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 10, 99);

DateTime d1 = DateTime.Now;
int[,] arr2DNew = SquareOfEvenIndices(arr2D);
Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;
FillArrayMod2Square(arr2D);
Console.WriteLine(DateTime.Now - d2);
Print2DArray(arr2D);
Console.WriteLine();
Print2DArray(arr2DNew);