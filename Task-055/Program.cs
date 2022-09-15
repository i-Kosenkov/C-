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

int[,] GetNewDoubleArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultArray[j, i] = array[i, j];
        }
    }
    return resultArray;
}

int[,] array = new int[5, 5];

GetRandomDoubleArray(array);
PrintArray(array);
Console.WriteLine();
if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Массив не квадратный");
        return;
    }
int[,] newArray = GetNewDoubleArray(array);
PrintArray(newArray);