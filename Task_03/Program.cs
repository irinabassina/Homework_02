// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// ниже в комментарии пример идеального решения преподавателя (настроила, работает))

/* int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Not a day of the week!");
    return false;
}
int weekDay = Prompt("Input a day of the week  ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
*/



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
