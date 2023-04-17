// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2            -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
Console.Clear();

//спрашиваем длину массива
Console.Write("Введите количество элементов массива M: ");
int cnt = int.Parse(Console.ReadLine() ?? "0");

// запрашиваем значения массива у пользователя
int[] arr = new int[cnt];// создаем массив
int cntPos = 0;//вводим переменную для подсчета положительных чисел
for (int i=0; i<cnt; i++)
    {
        Console.Write("Введите " + i + "-й элемент массива: ");
        arr[i] = int.Parse(Console.ReadLine() ?? "0");
        if (arr[i]>0)
        {
            cntPos++;
        }
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
Print1Darray(arr);
Console.WriteLine("Количество положительных чисел: " + cntPos);