// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

// вариант 1

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine());

// int max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;

// Console.WriteLine($"Максимальное из введенных чисел - {max}");

// вариант 2

int[] num = new int[3];
int index=0;

while (index < num.Length)
{
    Console.Write($"Введите число {index+1}: ");
    num[index] = int.Parse(Console.ReadLine());
    index++;
}
int max = num[0];
index = 0;
while (index < num.Length)
{
    if (num[index]>max) max = num[index];
    index++;
}
Console.WriteLine($"Максимальное из введенных чисел - {max}");