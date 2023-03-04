// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите порядковый номер дня недели");
int numberA = Convert.ToInt32(Console.ReadLine());
if ( numberA <1) Console.Write("некорректный ввод");
else if (numberA>7) Console.Write("некорректный ввод");
else   Console.Write(numberA==6? "да":numberA==7? "да": "нет");
