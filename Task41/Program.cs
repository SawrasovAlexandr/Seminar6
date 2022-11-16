// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

int[] IntSpaceSeparetedInput(string series, out bool areNumbers)
{
    string[] numbers = series.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];
    areNumbers = true;
    int incorrect = 0;
    for (int i = 0, j = 0; i < numbers.Length; i++)
    {
        if (int.TryParse(numbers[i], out int num))
        {
            result[j] = num;
            j++;
        }
        else incorrect++;
    }
    if (incorrect == result.Length)
    {
        areNumbers = false;
        Array.Resize(ref result, 1);
    }
    else Array.Resize(ref result, result.Length - incorrect);
    return result;
}

Console.WriteLine("Введите ряд целых чисел, разделяя их пробелом: ");
int[] enteredNumbers = IntSpaceSeparetedInput(Console.ReadLine(), out bool areNum);
Console.WriteLine(String.Join(", ", enteredNumbers));
if (areNum)
{
    int countPosit = 0;
    foreach (var item in enteredNumbers)
    {
        if (item > 0) countPosit++;
    }
    Console.WriteLine($"Количество чисел больше нуля в введенном ряду: {countPosit}");
}
else
{
    Console.WriteLine("Вы не ввели ни одного целого числа!");
}
