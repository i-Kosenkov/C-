//Задача 59. Удалить строку и столбец где минимальное значение.

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

//Находим минимальное значение и удаляем строку и столбец.
int[,] GetNewArray(int[,] array)
{
    int min = array[0, 0];
    int indexI = 0;
    int indexJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }

    Console.WriteLine($"Минимальное значение {min} адрес [{indexI}, {indexJ}]");

    int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int x = 0;
    int y = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != indexI)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != indexJ)
                {
                    resultArray[x, y] = array[i, j];
                    y++;
                }
            }
            x++;
        }
        y = 0;

    }
    return resultArray;
}

int[,] array = new int[4, 4];

GetRandomDoubleArray(array);
PrintArray(array);
Console.WriteLine();

int[,] newArray = GetNewArray(array);
PrintArray(newArray);