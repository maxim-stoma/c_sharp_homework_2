Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7)
{
    Console.WriteLine($"Ну и где ты видел {day} дней в неделе?");
}
else if (day < 1)
{
    Console.WriteLine($"Серьёзно? {day} день недели?");
}
else
{
    if (day < 6)
    {
        Console.WriteLine($"Тяжкий будний день...");
    }
    else
    {
        Console.WriteLine($"Выходной!");
    }
}
Console.ReadLine();