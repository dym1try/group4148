// Задача №35 Задайте одномерный массив из 123 случайных  чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [10,99].

// //Метод печати одномерного массива
// void Print1Darray(int []arr)
// {
//     Console.Write("[");
//     for(int i = 0; i<arr.Length-1; i++)
//     {
//         Console.Write(arr[i]+",");
//     }
//     Console.WriteLine(arr[arr.Length-1] + "]");
// }

// //Заполнение массива
// int[] Gen1DArray(int len, int top, int but)
// {
//     int[] res=new int[len];
//     for(int i=0; i<len; i++)
//     {
//         res[i]= new Random().Next(but, top+1);
//     }
//     return res;
// }

// //Подсчёт кол-ва в массиве
// int ElmInRange(int[] arr, int min, int max)
// {
//     int res = 0;
//     for(int i=0; i<arr.Length; i++)
//     {   
//         if(arr[i]<=max && arr[i]>=min)
//         {
//             res++;
//         }
//     }
//     return res;
// }

// int[] arr = Gen1DArray(123,1000,0);
// Print1Darray(arr);
// int res = ElmInRange(arr, 10, 99);
// Console.WriteLine("Элементов, лежащих в границах [10;99]: "+ res);

int[] Gen1DArr(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int SerchElementInArr(int[] arr)
{
    int count = 0;
    int minValue = 10;
    int maxValue = 99;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= minValue && arr[i] <= maxValue)
        {
            count++;
        }
    }
    return count;
}

int[] testArr = Gen1DArr(123, 1000, 1);
Print1DArr(testArr);
Console.WriteLine(SerchElementInArr(testArr));
