// Напишите программу, которая на вход принимает
//исло (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int n;
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
    
for (int i = 1; i <= n; i=i+1)
    if (i % 2 == 0)
        Console.Write(i + " " );