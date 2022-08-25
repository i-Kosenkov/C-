Console.Write("Введите Х: ");
bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

Console.Write("Введите Y: ");
bool isNumberY = int.TryParse(Console.ReadLine(), out int y);

if (isNumberX != true || isNumberY != true)
{
    Console.WriteLine("Числа введены не верно");
    return;
}

int result = GetPosition(x, y);
Console.WriteLine(result);

int GetPosition(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (x < 0 && y > 0)
    {
        return 2;

    }

    if (x < 0 && y < 0)
    {
        return 3;

    }
    if (x > 0 && y < 0)
    {
        return 4;

    }
    return -1;
}