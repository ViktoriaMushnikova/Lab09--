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