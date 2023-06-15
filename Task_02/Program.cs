// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6  if (num <= -1000 || (num > -100 && num  < 100) || num >= 1000)


int ThirdDigit(int number)
{
    if (number >= 100 || number <= -100)
    {
        int result = 0;
        while (number > 999 || number <= -999)
        {
            number = number / 10;
        }
        result = number % 10;
        if (result < 0)
        {
            result = result * -1;
        }
        return result;
    }
    else
    {
        return -1;
    }
}
Console.Write("Ведите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
 
if (ThirdDigit(number1) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра это {ThirdDigit(number1)}");