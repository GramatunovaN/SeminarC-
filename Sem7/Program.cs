// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

// using System.Globalization;

// Console.WriteLine("Введите число");
// int N =Convert.ToInt32(Console.ReadLine());

// int summ = 0;
// while (N>0)
// {
//     summ+=N%10;
//     N/=10;
// }
// Console.WriteLine(summ);
// int Function(int N)
// {
//     if(N==0)
//     { 
//         return 0;
//     }
// return N%10 + Function(N/10);
// }
// Console.WriteLine(Function(N));

// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

using System.Data;
using System.Runtime.Intrinsics.X86;

// Console.WriteLine("Введите число");
// int N =Convert.ToInt32(Console.ReadLine());

// while(N>X)
// {
//     X=X+1;
//     Console.Write(X+" ");
// }
// void Function(int N)
// { 
//     if(0==N)
//     { 
//         return;
//     }
// Function(N-1);
// Console.Write(N);
// }
// Function(N);
// Напишите программу, которая принимает на вход 2 числа и возводит первое во второе
// Console.WriteLine("Введите число");
// int A =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int B =Convert.ToInt32(Console.ReadLine());
// int Function(int A, int B)
// { 
//     if(0==B)
//     { 
//         return 1;
//     }
//    return A*Function(A,B-1);
// }
// Console.WriteLine(Function(A,B));

// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Console.Write("Введите число M - ");
// int M =Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N - ");
// int N =Convert.ToInt32(Console.ReadLine());
// int Function(int M, int N)
// {  if (M>N)
// {
//     int replaceM=M;
//     M=N;
//     N=replaceM;
// }
//     if(M==N)
//     { 
//         return M;
//     }
//    Console.Write(M + ",");
//    return Function(M+1,N);
// }
// Console.WriteLine(Function(M,N));


// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// Console.Write("Введите число M - ");
// int M =Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N - ");
// int N =Convert.ToInt32(Console.ReadLine());
// // Функция Аккермана каждый следующий оператор определяется так, что предыдущий оператор  применяется {N-1} раз к числу M.
// // m = 2, n = 3 -> A(m,n) = 29
// int FunctionAk(int M, int N) 
//  {  
//     if (M==0) 
//     {
//         return N+1;
//     }
//     else  if (N==0) 
//     {
//         return FunctionAk(M-1,1);
//     }
//     else 
//     {
//         return FunctionAk(M-1,FunctionAk(M,N-1));
//     }
// }
// Console.WriteLine(FunctionAk(M,N));

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Console.Write("Введите длину массива - ");
// int aL =Convert.ToInt32(Console.ReadLine());

// int [] Creation ()
// {
// int [] array = new int[aL];
//  for ( int i=0; i<aL; i++)
// {
//     array[i]=new Random().Next(1,101);
//    }
//  return array;
// }
//  void Print (int [] array) 
//  {
//     for ( int i=0; i<aL; i++)
//     {
//         Console.Write(array[i] + " " );
//     }
//  }
// int []array= Creation();
// Print(array);
// Console.WriteLine(" ");
// Function(array,aL);
// void Function(int []array, int aL)
// { 
//     if(aL==0)
//     { 
//         return;
//     }
//     Console.Write(array[aL-1] + ", ");
//     Function(array,aL-1);
// }