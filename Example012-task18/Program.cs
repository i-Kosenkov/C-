Console.Write("Введите номер четверти 1-4: ");
int x = Convert.ToInt32(Console.ReadLine());

string result = GetPosition(x);
Console.WriteLine(result);

string GetPosition(int y)
{
    switch (y)
    {
        case 1:
            return "x>0 y>0";
        case 2:
            return "x<0 y>0";
        case 3:
            return "x<0 y<0";
        case 4:
            return "x>0 y<0";
        default:
            return "Введено не верное значение";
    }
}