//Заполнить рандомно двумерный массив
void GetRandomDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//печать двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Находим сумму элементов диагонали версия 1
int GetSumDiagonalNumbers(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i, j];
                break;
            }
        }
    }
    return result;
}

//Находим сумму элементов диагонали версия 2
int GetSumDiagonalNumbers2(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i >= array.GetLength(1))
        {
            break;
        }
        result = result + array[i, i];
    }
    return result;
}

int[,] array = new int[5, 3];
GetRandomDoubleArray(array);
PrintArray(array);
int sum = GetSumDiagonalNumbers2(array);
Console.WriteLine();
Console.Write($"Сумма диагонали = {sum}");