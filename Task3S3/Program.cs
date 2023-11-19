// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
Console.WriteLine( "Введите размер массива" );
int lengthM=Convert.ToInt32(Console.ReadLine());
int [] array = new int[lengthM];
int [] array2 = new int[lengthM/2];
for ( int i=0; i<lengthM; i++)
{
    array[i]=new Random().Next(1,10);
    Console.Write(array[i] + " " );
    
 }
Console.WriteLine();
for ( int i=0, j=lengthM-1; i<lengthM/2; i++,j--) 
{
 array2[i]=array[i]*array[j];
Console.Write(array2[i] + " " );
}


//2  array2[i]=array[i]*array[^(i+1)];