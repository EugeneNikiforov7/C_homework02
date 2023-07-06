//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int max=num1, min=num2;

if (num1<num2) 
{
    max=num2;
    min=num1;
}
Console.WriteLine($"Из двух введенных чисел большее - {max}, меньшее - {min}");