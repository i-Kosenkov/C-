//Вывести значения от М до N

//Проверка вводимого числа 
Console.Write("Введите число: ");
bool isNum_m = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите число: ");
bool isNum_n = int.TryParse(Console.ReadLine(), out int n);
if (!isNum_m || !isNum_n)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int[] array = new int[n - m + 1];
int i = 0;
int[] Recursive(int m, int n)
{
    if (m <= n)
    {
        array[i] = m;
        m++;
        i++;
        Recursive(m, n);
    }
    return array;
}

//Печать массива
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

PrintArray(Recursive(m, n));
