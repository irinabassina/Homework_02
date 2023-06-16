// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Input a day of the week:  ");
int num = Convert.ToInt32(Console.ReadLine());

    if (num >= 1 && num <= 5)
    {
        Console.Write("No");
    }
    else if (num >= 6 && num <= 7)
    {
        Console.Write("Yes");
    }
    else Console.Write("Not a day of the week!");
