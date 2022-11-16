// Написать программу, которая принимает на вход трехзначное число и на выходе показывает ВТОРУЮ цифруэтого числа.
// Например : 
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число : ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (num > 99 & num < 1000)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    Console.WriteLine($"Втарая цифра вашего числа  :  {num2}");
}
else 
{
    Console.WriteLine("Вы ввели не трехзначное число! ");
}
