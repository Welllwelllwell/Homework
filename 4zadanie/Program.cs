// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа 
// от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());

for (int I = 1; I <= numberN; I++)
{
    if (I % 2 == 0)
    {
        System.Console.WriteLine(I);
    }
}
