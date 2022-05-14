Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 999)
{
    Console.WriteLine("Я зря сказал трёхзначное?");
}
else if (num < 100)
{
    Console.WriteLine("Так, тут не хватает цифр");
}
else
{
    int mult1 = num % 100;
    int mult2 = mult1 / 10;
    Console.WriteLine($"Вторая цифра введённого числа {mult2}");
}
Console.ReadLine();