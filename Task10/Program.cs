// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB=numberA/10;
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
     Console.WriteLine($"{numberB%10} - вторая цифра");
}