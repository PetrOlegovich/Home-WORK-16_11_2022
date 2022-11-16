// Написать программу, которая принимает на ввод цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// Например : 
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("введите число обозначающий день недели : ");
int numDay = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (numDay < 8 & numDay > 0)
{
    if (numDay < 6)

    {
        Console.WriteLine("Это рабочий день");
    }
    else
    {
        Console.WriteLine("Это выходной день");
    }
}
else 
{
    Console.WriteLine("Нет такого дня недели !");
}
