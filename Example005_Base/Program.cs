Console.Write ("Insert first numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Insert second numbers: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Insert third numbers: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write ("Insert fourth numbers: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write ("Insert fifth numbers: ");
int e = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write ("Maximum number = ");
Console.WriteLine (max);