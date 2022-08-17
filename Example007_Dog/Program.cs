int count = 0;
Console.Write("Введите расстояние в метрах: ");
double dist = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость 1 человека км/ч: ");
int speed_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость 2 человека км/ч: ");
int speed_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость собаки км/ч: ");
int speed_dog = Convert.ToInt32(Console.ReadLine());
int friend = 2;
double time = 0;
while (dist > 5)
{
    if (friend == 1)
    {
        time = dist / (speed_1 + speed_dog);
        friend = 2;
    }
    else
    {
        time = dist / (speed_2 + speed_dog);
        friend = 1;
    }
    dist = dist - (speed_1 + speed_2) * time;
    count++;
}
Console.Write ("Собака пробежала: ");
Console.Write (count);
Console.Write (" раз");