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

Console.WriteLine(GetNumberTrueFalse(array,y));

bool GetNumberTrueFalse(int[] array, int a)
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == a) return true;
}
    return false;
}

//Вывод данных из массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

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