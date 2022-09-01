//Разделите строку на массив из пар по два символа. Если строка содержит нечетное количество символов, 
//пропущенный второй символ последней пары должен быть заменен подчеркиванием "_". 
//Входные данные: Строка (0 <= len(str) <= 100 ). 

// "abcd" == ["ab", "cd"]
// "abc" == ["ab", "c_"]
// "abcdf" == ["ab", "cd", "f_"]
// "a" == ["a_"]
// "" == [""]

Console.Write("Введите значение: ");
string x = Console.ReadLine();

int l = x.Length;
if (l % 2 != 0) x = x + '_';

string[] GetNumber(string a)
{
    int y = 0;
    string[] array = new string[a.Length / 2];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = a[y] + "" + a[y + 1];
        y = y + 2;
    }
    return array;
}

Console.WriteLine(string.Join(" ", GetNumber(x)));