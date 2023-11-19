// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Введите трехзначное число");
int num=Convert.ToInt32(Console.ReadLine());
if (num < 100 || num > 999)
{
Console.WriteLine("Число не является трехзначным!");
return;
}
int[]array = new int [3];
for(int i=0; i<3; i++)
{
    array[i]=num%10;
    Console.Write(array[i]+" ");
    num/=10;
}
