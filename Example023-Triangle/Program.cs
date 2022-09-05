Console.Write("Введите х: ");
bool isNumberX = int.TryParse(Console.ReadLine(), out int x);
Console.Write("Введите y: ");
bool isNumberY = int.TryParse(Console.ReadLine(), out int y);
Console.Write("Введите z: ");
bool isNumberZ = int.TryParse(Console.ReadLine(), out int z);

if (!isNumberX || !isNumberY || !isNumberZ)
{
    Console.WriteLine("Invalid number");
    return;
}

bool CheckTriangle(int a, int b, int c)
{
    if (x >= y + z && y >= x + z && z >= y + x)
    {
        return true;
    }
    return false;
}

bool result = CheckTriangle(x, y, z);
Console.WriteLine(result);