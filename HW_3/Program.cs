// Задача 6: Напишите программу, которая на вход принимает число
// и выдает, является ли число четным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1 % 2 == 0)
Console.WriteLine("y");
else
Console.WriteLine("no");

