// Задача №61 Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника.
//                1
//               1 1
//              1 2 1
//             1 3 3 1
//            1 4 6 4 1
//           1 5 1010 5 1 

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

long Factor(int n)
{
    long res = 1;
    for(int i=1;i<=n;i++)
    {
        res*=i;
    }
    return res;
}

void PrintPascalTriangle(int nRaw)
{
    for(int i=0;i<nRaw;i++)
    {
        for(int k = 0;k<nRaw-i;k++)
        {
            Console.Write(" ");
        }
        for(int j = 0; j<=i;j++)
        {
            Console.Write(" ");
            Console.Write(Factor(i)/(Factor(j)*Factor(i-j)));
        }
        Console.WriteLine();
    }
}

int countRaw = ReadData("Введите количество строк Треугольника Паскаля: ");
PrintPascalTriangle(countRaw);