// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


using System.Diagnostics.CodeAnalysis;

int[,] CreateArray()
{
Console.Write("Введите количество строк массива -");
int str=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива -");
int stl=Convert.ToInt32(Console.ReadLine());
int[,] array = new int[str, stl];
for (int i = 0; i < str; i++)
{
for (int j = 0; j < stl; j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
return array;
}
void PrintArray(int [,]array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + "  ");
}
Console.WriteLine();
} 
}
void Search(int [,]array)
{
Console.Write("Введите i -");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j -");
int B = Convert.ToInt32(Console.ReadLine());
if (A>=array.GetLength(0) || B>=array.GetLength(0)) 
{ Console.Write("Такого элемента нет ");}
else
{ 
for (int i = 0, j = 0; i < array.GetLength(0) && j < array.GetLength(1); j++, i++)
{
if (i==A && j==B)    
{
    Console.Write(array[i,j]+ "  ");
}
}
}
}
// int[,]array = CreateArray();
// PrintArray(array);
// Search(array);
// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// int[,]array = CreateArray();
// PrintArray(array);
// Console.WriteLine();
// int[,]array2 = ChangeArray(array);
// PrintArray(array2);
int[,] ChangeArray(int[,] array)
{
int[,] array2 = new int[array.GetLength(0),array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j <array.GetLength(1); j++)
{
if ( i==0)
    {array2[i, j]=array[array.GetLength(0)-1, j]; }
else if ( i==array.GetLength(0)-1)
    {array2[i, j]=array[0, j]; }
else 
{array2[i, j]=array[i, j]; }
}
}
return array2;
}

// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
int[,]array = CreateArray2();
PrintArray(array);
int[]array2 = Sum(array);
Console.Write("минимальная сумма = ");
minSum (array2);


int[,] CreateArray2()
{
Console.Write("Введите количество строк массива -");
int str=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива отличное от " + str + "  ");
int stl=Convert.ToInt32(Console.ReadLine());
int[,] array = new int[str, stl];
for (int i = 0; i < str; i++)
{
for (int j = 0; j < stl; j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
return array;
}

int[] Sum (int[,] array)
{
int[]array2 = new int [array.GetLength(0)];    
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array2[i]+=array[i,j];
}
Console.Write(array2[i]+ "  ");
} 
Console.WriteLine();
return array2;
}

void minSum (int[] array2)
{
  int  minSumma = array2[0];
for (int i = 0; i < array.GetLength(0); i++)
{   if (minSumma>array2[i]) 
    {minSumma=array2[i];}
}
Console.WriteLine(minSumma);
}
// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца
