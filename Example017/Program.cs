
//Вам дана строка состоящая только из цифр. Вам нужно посчитать сколько нулей ("0") находится в начале строки. 
//Входные данные: Строка (0-9) 

Console.Write("Введите число: ");
string x = Console.ReadLine();

if (x[0] != '0')
{
    Console.WriteLine("Первая цифра не 0");
    return;
}

int GetZero(string a)
{
    int lenght = a.Length;
    int result = 0;
    for (int i = 0; i < lenght; i++)
    {
        if (a[i] == '0')
        {
            result++;
        }
        else
        {
            return result;
        }
    }
    return result;
}

Console.WriteLine(GetZero(x));