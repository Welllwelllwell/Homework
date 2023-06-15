// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("ВВедите 1 число");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВедите 2 число");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Наибольшее число");
if (numberA > numberB)
{
    System.Console.WriteLine(numberA);
}

else 
{
    System.Console.WriteLine(numberB);
}

