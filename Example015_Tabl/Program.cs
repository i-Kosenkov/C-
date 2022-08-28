//Табилца умножения
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//Замена в тексте символа
// string text = "Как нам повторить"
//             + "То, что ушло навсегда?"
//             + "Знает лишь вечность...";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// Console.Write(Replace(text, ' ', '|'));


//Сортировка массива
int[] arr = { 7, 5, 3, 1, 2, 8, 4, 6, 1, 0, 3 };

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] > array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

//Перевернуть массив
void ReverseSort(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temporary = array[array.Length - i - 1];
        array[array.Length - i - 1] = array[i];
        array[i] = temporary;
    }
}

//Вывод массива на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr);
ReverseSort(arr);
PrintArray(arr);