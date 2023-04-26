// Перебор всех слов из заданных букв

char[] s = { 'а', 'и', 'с', 'в' };// задали массив из букв

int count = s.Length;// задали его длину

int n = 1;

for (int i = 0; i < count; i++)// перебор для одной буквы
{
    for (int j = 0; j < count; j++)// перебор для двух букв
    {
        for (int k = 0; k < count; k++)// перебор для трех букв
        {
            for (int l = 0; l < count; l++)// перебор для четырех букв
            {
                Console.WriteLine("Итеративный " + $"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
            }
        }
    }
}

void FindWords(string alphabet, char[] word, int length = 0)// рекурсия
{
    if (length == word.Length)
    {
        Console.WriteLine("Рекурсия " + $"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[4]);// счетчик получился общим на оба метода