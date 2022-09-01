Console.Write("Введите число: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

//Cумма от 1 до Х
int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

//Задача 26 - Количество цифр в числе
int CountNumber(int number)
{
    int i = 0;
    for (i = 0; number > 0; i++)
    {
        number = number / 10;
    }
    return i;
}

//Задача 28 - Произведение от 1 до Х
int GetProizv(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
    }
    return sum;
}


//Задача 30 - массив [8] заполенный 0 и 1
int[] RandomZeroOne(int[] array)
{
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumber.Next(0, 2);
    }
    return array;
}

//Вывод данных из массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write($"Задача 26 (количество цифр в числе): {CountNumber(x)}");

Console.WriteLine();

Console.Write($"Задача 28 (произведение от 1 до Х): {GetProizv(x)}");

Console.WriteLine();

int[] result = RandomZeroOne(new int[x]);
Console.Write($"Задача 30 (массив с 0 и 1): ");
PrintArray(result);