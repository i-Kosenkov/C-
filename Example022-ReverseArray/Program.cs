int[] GetReverseArray(int[] array)
{
    int[] reverseArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reverseArray[i] = array[array.Length - 1 - i];
    }
    return reverseArray;
}

void PrintArrya(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = new int[] { 1, 2, 3, 4, 5 };
PrintArrya(array);
int[] reverseArray = GetReverseArray(array);
Console.WriteLine();
PrintArrya(reverseArray);