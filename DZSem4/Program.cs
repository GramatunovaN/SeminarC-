// //Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

double Print()
{
Console.WriteLine("Введите целое число");
double number=Convert.ToDouble(Console.ReadLine());
return number;  
}
Console.WriteLine("Введите целое число");
int number=Convert.ToInt32(Console.ReadLine());
int count = counter();
double [] array = GenerateArray();
double Sum=SumNumbersRanks(array);
while( Sum%2==0)
{
Print();
}
int counter()
{
int count=0;
while (number>0)
{
     number=number/10;
    count=count+1;
}
return count;
}
double[] GenerateArray()
{
double [] array = new double[count];
for (int i = 0; i < count; i++)
    {
    array[i]=number%10;
    number/=10;
}
return array;
}

double SumNumbersRanks(double[] array)
{
double sum = 0;
for (int i = 0; i < count; i++)
{
sum += array[i] * Math.Pow(10, array.Length - i - 1);
}
return sum;
}

//  bool condition (int count) 
//  {
// for ( int i=0;i<count; i++)
//     {
//         if (number%i==0 || number==1 )
//         {
//             return false;
//         }

//     }
//     return true;
//  }



// //Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// Console.WriteLine("Введите длину массива");
// int lengthA=Convert.ToInt32(Console.ReadLine());
// int []array = GenerateArray();
// PrintArray(array);
// Console.WriteLine();

// int[] GenerateArray()
// {
// int[] array = new int[lengthA];
// for (int i = 0; i < lengthA; i++)
// {
// array[i] = new Random().Next(100, 1000);
// }
// return array;
// }
// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// }

// int counter (int [] array) 
//  {
//     int count=0;
//     for ( int i=0; i<array.Length; i++)
//     {
//        if(array[i]%2==0)
//        {
//         count++;
//        }
//     }
// return count;
//  }

// Console.WriteLine("количество четных чисел- " + counter(array));



// //Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// Console.WriteLine("Введите длину массива");
// int lengthA=Convert.ToInt32(Console.ReadLine());
// int []array = GenerateArray();
// PrintArray(array);
//// Console.WriteLine();
// int[] array2 = turnArray(array);
// PrintArray(array2);
//  int[] GenerateArray()
// {
// int[] array = new int[lengthA];
// for (int i = 0; i < lengthA; i++)
// {
// array[i] = new Random().Next(1, 10);
// }
// return array;
// }
// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// }
//  int[] turnArray(int []array)
// {
//     int [] array2 = new int[lengthA];
// for (int i = 0; i < lengthA; i++)
// {

//      array2[i]=array[^(i+1)];
// }
// return array2;
// }

