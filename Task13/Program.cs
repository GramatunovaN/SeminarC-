// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5                0123
// 78 -> третьей цифры нет 2668
// 32679 -> 6
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int thirdnumber=0;
if (number>=100)
{
while (number>=100)
{     
thirdnumber=number%10;
number=number/10;
}
Console.WriteLine($"Третья цифра-{thirdnumber}");
}
else 
{
Console.WriteLine("Третьей цифры нет");
}


