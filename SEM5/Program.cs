// InvalidOperationException("Logfile cannot be read-only");
// while (true)
// {
// 1.Ввод чисел
// 2. Проверка корректны ли числа
// 3. Если да, отрабатываем код и вызываем break
// 4. Если нет, цикл заканчивается и мы возвращаемся в начало
// Double A, B;
// while (true)
// {
// if (Double.TryParse(Console.ReadLine(), out A) && Double.TryParse(Console.ReadLine(), out B))
// {
// break;
// }
// }
// Console.WriteLine(A + " " + B);
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// int[,] array = GenerateArray2D();
// PrintArray(array);
// Console.WriteLine("___________");
// Square(array);
// PrintArray(array);
// Console.WriteLine("___________");


// int[,] GenerateArray2D()
// {
// int[,] array = new int[6, 6];
// for (int i = 0; i < array.GetLength(0); i++)//8
// {
// for (int j = 0; j < array.GetLength(1); j++)//6
// {
// array[i, j] = new Random().Next(1, 10);
// }
// }
// return array;
// }

// void PrintArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)//8
// {
// for (int j = 0; j < array.GetLength(1); j++)//6
// {
// Console.Write(array[i, j] + "\t");
// }
// Console.WriteLine();
// }
// }

// void Square(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)//8
// {
// for (int j = 0; j < array.GetLength(1); j++)//6
// {
// if (i % 2 == 0 && j % 2 == 0)
// {
// array[i, j] *= array[i, j];
// }
// }
// }
// }
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// int[,] array = new int[4, 4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = new Random().Next(1, 10);
// }
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i, j] + "\t");
// }
// Console.WriteLine();
// } 
// int result = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// { if(i==j) 
// {
//     result+= array[i,j];
// }
// }
// } 
// Console.WriteLine("Сумма элементов на диагонали - " + result);
// for (int i = 0, j = 0; i < array.GetLength(0) && j < array.GetLength(1); j++, i++
// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.
int[,] array = new int[3, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + "\t");
}
Console.WriteLine();
} 
double[]array2 = new double[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(0); j++)
{
array2[i]+=array[i,j];
}
array2[i]=array2[i]/array.GetLength(0);
Console.Write(array2[i]+ "  ");
} 