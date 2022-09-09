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

//Находим четные индексы
void GetIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}

int[,] array = new int[4, 6];
GetRandomDoubleArray(array);
PrintArray(array);
GetIndex(array);
Console.WriteLine();
PrintArray(array);

