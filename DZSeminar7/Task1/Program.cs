// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
Console.Write("Введите число M - ");
int M =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N - ");
int N =Convert.ToInt32(Console.ReadLine());
int Function(int M, int N)
{  if (M>N)
{
    int replaceM=M;
    M=N;
    N=replaceM;
}
    if(M==N)
    { 
        return M;
    }
   Console.Write(M + ",");
   return Function(M+1,N);
}
Console.WriteLine(Function(M,N));
