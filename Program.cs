/*
Задача 17
Напишите программу, которая принимает на входе координаты точки (X и Y),
причем X не = 0 и Y не = 0 и выдает номер четверти плоскости, в которой
находиться эта точка
*/

Console.Write("Введите координату по oX:  ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по oY:  ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine();
    Console.WriteLine ("Координаты: " + "(" + x + "," + y +") - " + "I четверть");
}
    else if (x < 0 && y > 0)
{
     Console.WriteLine();
     Console.WriteLine ("Координаты: " + "(" + x + "," + y +") - " + "II четверть");
}
    else if (x < 0 && y < 0)
{
     Console.WriteLine();
     Console.WriteLine ("Координаты: " + "(" + x + "," + y +") - " + "III четверть");
}
    else if (x > 0 && y < 0)
{
     Console.WriteLine();
     Console.WriteLine ("Координаты: " + "(" + x + "," + y +") - " + "IV четверть");
}
else
{
    Console.WriteLine();
    Console.WriteLine ("Вы попали в координатную ось");   
}

