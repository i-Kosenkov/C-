int count = 0;
int friend = 2;
double time = 0;
double all_time = 0;
double all_dist = 0;

Console.Write("Введите расстояние в метрах: ");
double dist = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость 1 человека км/ч: ");
double speed_1 = Math.Round(Convert.ToDouble(Console.ReadLine()) * 1000 / 3600, 2);
Console.Write("Введите скорость 2 человека км/ч: ");
double speed_2 = Math.Round(Convert.ToDouble(Console.ReadLine()) * 1000 / 3600, 2);
Console.Write("Введите скорость собаки км/ч: ");
double speed_dog = Math.Round(Convert.ToDouble(Console.ReadLine()) * 1000 / 3600, 2);

while (dist > 1)
{
    if (friend == 1)
    {
        time = dist / (speed_1 + speed_dog);
        friend = 2;
        all_time = all_time + time;
    }
    else
    {
        time = dist / (speed_2 + speed_dog);
        friend = 1;
        all_time = all_time + time;
    }
    dist = dist - (speed_1 + speed_2) * time;
    all_dist = all_dist + dist;
    count++;
}
Console.Write($"Собака пробежала {Math.Round(all_dist, 2)} м. ");
Console.Write($"и развернулась {count} раз за ");
var ts = TimeSpan.FromSeconds(Math.Round(all_time, 0));
Console.WriteLine("{1} ч. {2} м. {3} с.", ts.Days, ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);