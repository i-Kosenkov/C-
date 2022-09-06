//Проверка вводимого числа 
Console.Write("Введите число: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

Console.WriteLine($"{x}! = {Factorial(x)}");