// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine($"Число {a} больше числа {b}");
}
else if (a < b)
{
    System.Console.WriteLine($"Число {b} больше числа {a}");
}
else
{
    System.Console.WriteLine($"Число {a} равно числу {b}");
}