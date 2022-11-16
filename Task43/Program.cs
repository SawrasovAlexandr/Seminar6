// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetInt(string? value)
{
    int number = 0;
    while (!int.TryParse(value, out number))
    {
        Console.Write("Введенное выражение не является целым числом. Повторите ввод: ");
        value = Console.ReadLine();
    }
    return number;
}

void GetArguments(out int k1, out int b1, out int k2, out int b2)
{
    int[] numbers = new int[4];
    string[] argument = {"k1", "b1", "k2", "b2"};
    for (int i = 0; i < argument.Length; i++)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine
        ($"Введите аргумент уравнения:\n y = {argument[0]} * x + {argument[1]} \n y = {argument[2]} * x + {argument[3]}");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"{argument[i]}: ");
        numbers[i] = GetInt(Console.ReadLine());
        argument[i] = Convert.ToString(numbers[i]);
    }
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($" y = {argument[0]} * x + {argument[1]} \n y = {argument[2]} * x + {argument[3]}");
    k1 = numbers[0];
    b1 = numbers[1];
    k2 = numbers[2];
    b2 = numbers[3];
}


GetArguments(out int k1, out int b1, out int k2, out int b2);
if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают!");
else if (k1 == k2) Console.WriteLine("Прямые параллельны!");
else
{
    double x = (double) (b2 - b1) / (k1 - k2);
    double y = (double) k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке ({Math.Round(x, 1)}; {Math.Round(y, 1)}).");
} 
