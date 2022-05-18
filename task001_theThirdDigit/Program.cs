Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int div = num;
int mult;

if (num < 100)
{
    Console.WriteLine("Ну...третьей цифры тут нет.");
}
else
{
    for (num = div; div > 1000; div = div / 10);

    mult = div % 10;
    Console.WriteLine($"Третья цифра введённого числа {mult}");
}
Console.ReadLine();