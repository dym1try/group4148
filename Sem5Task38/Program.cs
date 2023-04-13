// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76         [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.

Console.Clear();

//Ввод длины массива
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Метод печати одномерного массива
void Print1Darray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Заполнение массива ВЕЩЕСТВЕННЫМИ ЧИСЛАМИ
double[] Gen1DArray(int len, int top, int but)
{
    double[] res = new double[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().NextDouble() * 200 - 100; // Задал диапазон от -100 до 100
    }
    return res;
}

double DiffMinMax(double[] arr) // Находим минимум, максимум и разницу между ними
{
    double res = 0;
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];

    }
    res = max - min;
    return res;
}

int lenArr = ReadData("Введите длину массива: ");
double[] arr = Gen1DArray(lenArr, 999, 100);
Print1Darray(arr); // выводим массив
DiffMinMax(arr);
Console.WriteLine("Разница между максимальным и минимальным элементами: " + DiffMinMax(arr));