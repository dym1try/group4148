//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
//ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
//массивами. //Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

//спрашиваем длину массива
Console.Write("Введите количество элементов массива M: ");
int cnt = int.Parse(Console.ReadLine() ?? "0");

// запрашиваем значения массива у пользователя
string[] arr = new string[cnt];// создаем массив

for (int i=0; i<cnt; i++)
    {
        Console.Write("Введите " + i + "-й элемент массива: ");

        arr[i] = char.Parse(Console.ReadLine() ?? "0");
        arr[i] = arr[i].ToString();
        if (arr.Length[i]<=3)
        {
           
        }
    }

//Метод печати одномерного массива
void Print1Darray(string []arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}
Print1Darray(arr);
Console.WriteLine("Количество положительных чисел: ");