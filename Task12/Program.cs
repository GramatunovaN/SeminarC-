// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите два числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int del=numberA%numberB;
if (del==0)
{
Console.WriteLine($"Число {numberA} кратно {numberB}");
}
else
{
Console.Write($"Число {numberA} не кратно {numberB}, остаток от деления равен {del}");
}