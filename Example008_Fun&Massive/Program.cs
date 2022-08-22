// Console.Write("Введите 3 значения ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
int fun_max(int x, int y, int z)
{
    int max = x;
    if (y > max) max = y;
    if (z > max) max = z;
    return max;
}

int[] array = { 1, 2, 983, 4, 75, 6, 987, 8, 9 };
int n = array.Length;
int find = 75;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
        index++;
    }
int max = fun_max(
fun_max(array[0], array[1], array[2]),
fun_max(array[3], array[4], array[5]),
fun_max(array[6], array[7], array[8])
);
Console.WriteLine(max);
