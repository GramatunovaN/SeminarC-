// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("Введите трехзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA>999)
{ 
    Console.WriteLine($"{numberA} - не трехзначное число");
} 
else if(numberA<100)
{ 
    Console.WriteLine($"{numberA} - не трехзначное число");
} 
else 
{
     Console.WriteLine($"{numberA%10} - последняя цифра");
}