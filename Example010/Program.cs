//Задача 11
// Random Random = new Random();
// int RandomNumber = Random.Next(100, 1000);
// int FirstNumber = RandomNumber / 100;
// int LastNumber = RandomNumber % 10;
// int MiddleNumber = (RandomNumber / 10) % 10;
// Console.WriteLine($"Рандомное число {RandomNumber}");
// Console.WriteLine($"Первая цифра {FirstNumber}");
// Console.WriteLine($"Средняя цифра {MiddleNumber}");
// Console.WriteLine($"Последняя цифра {LastNumber}");
// Console.WriteLine(FirstNumber * 10 + LastNumber);

//Задача 12
Console.Write("Введите первое число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int y = Convert.ToInt32(Console.ReadLine());
// if (x % y == 0) 
// {
// Console.Write("кратно");
// }
// else
// {
//     Double z = y % x;
//     Console.Write($"не кратно, остаток от деления = {z}");
// }

//Задача 14
// if (x % 7 == 0 || x % 23 == 0)
// {
//     Console.Write("число кратно 7 и 23");
// }
// else
// {
//     Console.Write("число не кратно 7 и 23");
// }

//Задача 16
// if (x * x == y)
// {
//     Console.Write($"Число {y} является квадратом {x}");
// }
// else if (y * y == x)
// {
//     Console.Write($"Число {x} является квадратом {y}");
// }
// else
// {
//     Console.Write($"Числа {x} и {y} не являются квадртами");
// }

bool CheckDel(int x, int y)
{
    if (x == y * y || y == x * x)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool z = CheckDel(x, y);
if (z == true)
{
    Console.Write($"Число {y} является квадратом {x}");
}
else
{
    Console.Write($"Число {y} не является квадратом {x}");
}