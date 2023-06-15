// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("ВВедите 1 число");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВедите 2 число");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВедите 3 число");
int numberC = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Наибольшее число");

int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
System.Console.WriteLine(max);
