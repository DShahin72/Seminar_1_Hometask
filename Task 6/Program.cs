// Напишите программу, которая на вход принимает число и выдает, является ли число четным

System.Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    System.Console.WriteLine($"Число {a} - четное");
}
else
{
    System.Console.WriteLine($"Число {a} - нечетное");
}