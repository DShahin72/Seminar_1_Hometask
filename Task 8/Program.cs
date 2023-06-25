// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

System.Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    System.Console.WriteLine("Вы ввели ненатуральное число!");
}

for (int i = 2; i <= N; i += 2)
{
    System.Console.Write(i + " ");
}