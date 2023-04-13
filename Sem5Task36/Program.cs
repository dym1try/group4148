// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях. ODD 
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0        * Найдите все пары в массиве и выведите пользователю

// В конце 5 семинара Вы прочитали это Д\З, как сумму ЧЕТНЫХ позиций. В семинаре pdf и в ЛК написано про
// НЕЧЕТНЫЕ... Решил сделать подсчет нечетных.

//Ввод длины массива
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Метод печати одномерного массива
void Print1Darray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

int SumElmOddPos(int[] arr) // считаем сумму элементов, стоящих на нечётных позициях.
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}
int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(lenArr, 999, 100);
Print1Darray(arr); // выводим массив
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + SumElmOddPos(arr));