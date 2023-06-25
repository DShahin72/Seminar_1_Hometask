// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

System.Console.WriteLine($"{max} - максимальное число");