// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генератор 3-мерного массива - кол-во строк, столбцов, верх, низ

int[,,] Gen3DArray(int countRow, int countColumn, int countDep, int minValue, int maxValue)
{
    int[,,] arr = new int[countRow, countColumn, countDep];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countDep; k++)
            {
                arr[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return arr;
}

// Метод печати 3 мерного массива 
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)

            {
                Console.WriteLine(i + "," + j + "," + k + " = " + arr[i, j, k]);
            }
        }
    }
}


int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int dep = ReadData("Введите глубину массива: ");

int[,,] arr = Gen3DArray(row, col, dep, 10, 99);
Print3DArray(arr);
