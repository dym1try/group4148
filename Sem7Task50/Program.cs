// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генератор 2-мерного массива - кол-во строк, столбцов, верх, низ

int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}
// Метод печати 2 мерного массива 
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


void SearchElm2DArr(int[,] arr, int numN)
{
    bool elFind = false;
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (numN == arr[i,j])
            {
                Console.WriteLine("Элемент найден, ячейка: " + i  + "," + j + ".");
                elFind = true;
                //break;
            }
        }
    }
    if (elFind == false)
    {
        Console.WriteLine("Элемент не найден.");
    }
}



int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int numN = ReadData("Введите нужное число: ");

int[,] arr = Gen2DArray(row, col, 10, 99);
Print2DArray(arr);
SearchElm2DArr(arr, numN);