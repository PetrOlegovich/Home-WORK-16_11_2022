// написать программу, которая выводит третью цифру заданного числа, или сообщает что третьей цифры нет.
// Например : 
// 645    -> 5
// 78     -> третьей цифры нет
// 32679  -> 6

Console.WriteLine("Введите число : ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string str = num.ToString();

if (num > 100)
{
    Console.WriteLine($"Третья цифра : {str[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}