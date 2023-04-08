// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 

Console.Clear();

int ReadData(string message) //
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void Print1DArr(int[] arr) // печать массива в []
{
     Console.Write("[");
     for (int i =0; i <arr.Length -1; i++)
     {
          Console.Write(arr[i]+",");
     } 
     Console.WriteLine(arr[arr.Length-1]+"]");              
}

int[] Gen1DArr(int len, int top, int but) // генератор массива - длина, верх, низ
{
    int[] res = new int[len];
    for(int i=0; i<len;i++)
    {
        res[i] = new Random().Next(but,top+1);
    }
    return res;
}
int lenArr = ReadData("Введите длину массива: ");
int but = ReadData("Введите минимальное значение числа: ");
int top = ReadData("Введите максимальное значение числа: ");
int[] arr = Gen1DArr(lenArr,top,but);
Print1DArr(arr);