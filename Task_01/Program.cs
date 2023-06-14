// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= -1000 || (num > -100 && num  < 100) || num >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста, попробуйте еще раз"); 
    return;
}
int secondRank = num /10 % 10;
Console.WriteLine(secondRank);