//Табилца умножения
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

string text = "Как нам повторить"
            + "То, что ушло навсегда?"
            + "Знает лишь вечность...";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

Console.Write(Replace(text, " ", "|"));