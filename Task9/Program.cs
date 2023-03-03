// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int numberA = new Random().Next(10,100);
Console.WriteLine($"Случайное число - {numberA}");
int first = numberA/10;
int second = numberA%10;
if (first>second)
    {
      Console.WriteLine($"Наибольшая цифра - {first}");  
    }
else if (first==second)
    {
      Console.WriteLine($"Цифры одинаковые");  
    }    
else
{
    Console.WriteLine($"Наибольшая цифра - {second}");
}
