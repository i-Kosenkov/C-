//Задача 69. Возводит число А в степень В с помощью рекурсии

//Проверка вводимого числа 
Console.Write("Введите число: ");
bool isNum_a = int.TryParse(Console.ReadLine(), out int a);
Console.Write("Введите число: ");
bool isNum_b = int.TryParse(Console.ReadLine(), out int b);
if (!isNum_a || !isNum_b)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int i = 1;
int sum = 1;
int GetDegreeNumber(int a, int b)
{
    if (i <= b)
    {
        sum = sum * a;
        i++;
        //Console.WriteLine(sum);
        GetDegreeNumber(a, b);
    }
    return sum;
}
Console.WriteLine(GetDegreeNumber(a, b));