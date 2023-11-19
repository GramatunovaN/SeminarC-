// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int [] array = new int[10];
// for ( int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(1,101);
//     Console.Write(array[i] + " " );
// }
//  Console.WriteLine();
// int count=0;
// for ( int i=0; i<array.Length; i++)
// {
//     if (array[i]>=20 && array[i]<=90) count++;
// }
// Console.Write("Количество элементов массива принадлежащих заданному промежутку равно " + count);
// Задача 2: Задайте массив на 10 целых чисел. 
//Напишите программу, которая определяет количество чётных чисел в массиве.

// double [] array = new double[10];
// for ( int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(-100,100);
//     Console.Write(array[i] + " " );
// }
//  Console.WriteLine();
// int count=0;
// for ( int i=0; i<array.Length; i++)
// {
//     if (array[i]%2==0) count++;
// }
// Console.Write("Количество четных элементов равно " + count);


// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.


// Console.WriteLine( "Введите размер массива" );
// int lengthM=Convert.ToInt32(Console.ReadLine());
// double [] array = new double[lengthM];
// double min =0;
// double max = 0;
// for ( int i=0; i<lengthM; i++)
// {
//     array[i]=new Random().Next(-100,100);
//     Console.Write(array[i] + " " );
//     min=array[0];
//     max=array[0];
// }
// Console.WriteLine();
// for ( int i=0; i<lengthM; i++)
// {
//          if (min>array[i]) min=array[i];
//          if (max<array[i])  max=array[i];
// }

//  Console.WriteLine("минимальное значение равно " + min + ", максимальное значение равно "+ max);
//  Console.WriteLine("Разница максимального и минимального равно " + (max-min));

// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.
// Размер массива должен быть равен количеству цифр.
using System.Globalization;

Console.WriteLine("Введите число");

int num=Convert.ToInt32(Console.ReadLine());
if (num < 0 || num > 100000)
{
Console.WriteLine("Попробуйте снова!");
return;
}
int count=0;
int number = num;
while (number>0)
{
     number=number/10;
    count=count+1;
}
int[]array = new int [count];
for(int i=0; i<count; i++)
{
    array[i]=num%10;
    num/=10;
}
Console.WriteLine();
int[]array2 = new int [count];
for(int i=0; i<count; i++)
{
    array2[i]=array[^(i+1)];
    Console.Write(array2[i]+" ");
}