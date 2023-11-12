// 14.
// Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA%7==0 && numberA%23==0) Console.WriteLine($"Число {numberA} кратно 7 и 23 одновременно");
else Console.WriteLine($"Число {numberA} не кратно 7 и 23 одновременно");