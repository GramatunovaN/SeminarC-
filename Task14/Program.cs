// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
Console.WriteLine("Введите два числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB%numberA==0 ) Console.Write($"Второе число кратно первому");
else if (numberA%numberB==0 ) Console.Write($"Первое число кратно второму");
else   Console.Write($" Одно число не кратно другому, остаток от деления {numberB%numberA}");
