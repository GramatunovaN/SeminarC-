// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.WriteLine("Введите два числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB==numberA*numberA) Console.Write($"Число {numberB} является квадратом числа {numberA} ");
else   Console.Write($"Число {numberB} не является квадратом числа {numberA} ");

