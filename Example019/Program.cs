//Проверка вводимого числа 
Console.Write("Введите длину массива: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int [] array = GetArray(x);

Console.Write("Введите искомое значение: ");
bool isNum_y = int.TryParse(Console.ReadLine(), out int y);

Console.WriteLine(Contains(array,y));

//Заполняем массив
int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

//Ищем число в массиве
bool Contains(int[] array, int a)
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == a) 
    {
        return true;
    }
}
    return false;
}