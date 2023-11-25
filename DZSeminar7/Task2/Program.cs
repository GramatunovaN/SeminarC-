// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

Console.Write("Введите число M - ");
int M =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N - ");
int N =Convert.ToInt32(Console.ReadLine());
// Функция Аккермана каждый следующий оператор определяется так, что предыдущий оператор  применяется {N-1} раз к числу M.
// m = 2, n = 3 -> A(m,n) = 29
int FunctionAk(int M, int N) 
 {  
    if (M==0) 
    {
        return N+1;
    }
    else  if (N==0) 
    {
        return FunctionAk(M-1,1);
    }
    else 
    {
        return FunctionAk(M-1,FunctionAk(M,N-1));
    }
}
Console.WriteLine("Функция Аккермана ("+ M + ","+ N + ") равна " + FunctionAk(M,N));

