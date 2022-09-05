//Печать массива
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

//Проверка вводимого числа 
Console.Write("Введите число: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

//Заполнить массив рандомными числами (вводим размер массива)
int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;
}

GetRandomArray(x);
int[] array = GetRandomArray(x);
PrintArray(array);
int[] array2 = CopyArray(array);
Console.WriteLine();
PrintArray(array2);