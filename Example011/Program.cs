Console.Write("Введите номер четверти 1-4: ");
bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

// if (isNumberX != true || isNumberY != true)
// {
//     Console.WriteLine("Числа введены не верно");
//     return;
// }

string result = GetPosition(x);
Console.WriteLine(result);

string GetPosition(int x)
{
    switch(x)
    {
case 1:
return "x>0 y>0";
case 2:
return "x<0 y>0";
case 3:
return "x<0 y<0";
case 4:
return "x>0 y<0";
default "Введено не верное значение";
    }
}