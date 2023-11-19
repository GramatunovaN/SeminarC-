// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, а положительные на отрицательные.
int [] array = new int[10];
int [] array2 = new int[10];
for ( int i=0; i<array.Length; i++)
{
    array[i]=new Random().Next(-11,11);
    Console.Write(array[i] + " " );
}
 Console.WriteLine();
for ( int i=0; i<array.Length; i++)
{
        Console.Write(array[i]*(-1) + " " );
}
