Console.WriteLine("Введите координаты точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double GetDistance(int a, int b, int c, int d)
{
double result = Math.Sqrt((c - a)*(c - a) + (d - b)*(d - b));
return result; 
}

double res = GetDistance (x1, y1, x2, y2);
Console.WriteLine(res);