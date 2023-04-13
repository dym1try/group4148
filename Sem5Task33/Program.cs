// Задача №33 Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// Например: 4; массив [6, 7, 19, 345, 3] -> нет   ///    -3; массив [6, 7, 19, 345, 3] -> да

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод печати одномерного массива
void Print1Darray(int []arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    int[] res=new int[len];
    for(int i=0; i<len; i++)
    {
        res[i]= new Random().Next(but, top+1);
    }
    return res;
}

void SearchElmArr(int[] arr, int numN)
{
    bool elFind = false;
    for(int i=0; i<arr.Length; i++)
    {          
        if(numN == arr[i])
        {
            Console.WriteLine("элемент найден, ячейка: "+ i);
            elFind = true;
            //break;
        }
    }
    if (elFind == false)
    {
        Console.WriteLine("элемент не найден");
    } 
}

int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(lenArr,9,-9);
Print1Darray(arr);
int num = ReadData("Введите искомый элемент: ");
SearchElmArr(arr, num);