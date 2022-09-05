Console.Write("Введите десятичное число: ");
bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

string ConvertDoubleNumber(int number)
{
    string result = "";
    while (x > 0)
    {
        int sum = x % 2;
        x = x / 2;
        result = Convert.ToString(sum) + result;
    }
    return result;
}
Console.WriteLine(ConvertDoubleNumber(x));