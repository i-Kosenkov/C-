//Задача 67. Выводит сумму цифр введеного числа

//Проверка вводимого числа 
Console.Write("Введите число: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int sum = 0;

int GetSumNumber(int number)
{
    if (number % 10 > 0)
    {
        sum += number % 10;
        number = number / 10;
        GetSumNumber(number);
    }
    return sum;
}

Console.WriteLine(GetSumNumber(x));