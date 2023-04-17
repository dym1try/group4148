// Задача №39 Напишите программу, которая перевернёт одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.) Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1) менять числа местами в исходном массиве; 
// 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.

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

void SwapArray1(int[] arr)// 1 метод - изменение исходного массива
{
    int buf = 0;//вводим буферную переменную
    for(int i=0; i<arr.Length/2;i++)// проходим половину массива
    {
        //(arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]); можно и так, но на старых может не работать
        buf = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = buf;
    }
}

int[] SwapNewArray2(int[] arr)
{
    int[] outarr = new int[arr.Length];// создаем новый массив той же длины
    for (int i = 0; i < arr.Length; i++)
    {
        outarr[i]=arr[arr.Length-i-1];
    }
    return outarr;
}

int[] arr = Gen1DArray(15, 999, 100); // Сами задаем параметры массива
Print1Darray(arr); // выводим исходный массив
SwapArray1(arr);// выполняем первый метод
Print1Darray(arr); // выводим измененный массив по первому методу

SwapNewArray2(arr);// выполняем второй метод
Print1Darray(arr); // выводим измененный массив по второму методу