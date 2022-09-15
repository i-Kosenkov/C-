//Задача 53. Поменять местами первую и последнюю строки.

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

//Меняем первую и последнюю строки
int[,] ChangeRow(int[,] array)
{
    int numberArray = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        numberArray = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = numberArray;
    }
    return array;
}

int[,] array = new int[5, 5];
GetRandomDoubleArray(array);
PrintArray(array);
int [,] resultArray = ChangeRow(array);
Console.WriteLine();
PrintArray(resultArray);