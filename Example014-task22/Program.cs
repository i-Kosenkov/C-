Console.Write("Введите число N: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x || x <= 0)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int[] GetSqrt(int z)
{
    int i = 1;
    int[] array = new int[z];
    while (i <= z)
    {
        array[i - 1] = (int)Math.Pow(i, 2);
        i++;
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    int lenght = array.Length;
    while (i < lenght)
    {
        Console.Write($"{array[i]} ");
        i++;
    }
}

PrintArray(GetSqrt(x));