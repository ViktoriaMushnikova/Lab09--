int totalExercises = 1;

for (int number = 8; number >= totalExercises; number--)
{
    Console.WriteLine($"Упражнение {number}");
}
Console.WriteLine("Домашнее задание готово");


for (int room = 2; room <= 50; room += 3)
{
    if (room % 5 != 0)
    {
        continue;
    }
    Console.WriteLine($"Кабинет {room}");
}


int totalWeeks = 3;
for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
        if (day == 5)
        {
            Console.WriteLine("^_^");
        }
    }

}


int count = 0;
for (int ticket = 4; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        count += 1;
        continue;
    }

    Console.WriteLine($"Первый доступный билет : {ticket}, пропущенно {count}");
    break;
}