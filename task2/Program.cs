// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();

int index = 2;
while (index <= number)
{
    Console.WriteLine(index);
    index += 2;
}
