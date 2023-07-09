// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
Console.Clear();
Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int maxi = n1;
if (n2 > maxi)
maxi = n2;
if (n3 > maxi)
maxi = n3;
Console.WriteLine(maxi);
