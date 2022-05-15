Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("Ну...третьей цифры тут нет.");
}
else
{
    while (num > 1000)
    {
        num = num / 10;
    }
    int mult = num % 10;
    Console.WriteLine($"Третья цифра введённого числа {mult}");
}
Console.ReadLine();