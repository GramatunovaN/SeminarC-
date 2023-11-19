// Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

// Примеры

// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

// int [] Creation ()
// {
// int [] array = new int[8];
//  for ( int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(1,101);
//    }
//  return array;
// }
//  void Print (int [] array) 
//  {
//     for ( int i=0; i<array.Length; i++)
//     {
//         Console.Write(array[i] + " " );
//     }

//  }
//  bool isSimple (int number) {
// for ( int i=2; i<number; i++)
//     {
//         if (number%i==0 || number==1 )
//         {
//             return false;
//         }

//     }
//     return true;
//  }
//  int counter (int [] array) 
//  {
//     int count=0;
//     for ( int i=0; i<array.Length; i++)
//     {
//        if (isSimple(array[i]))
//        {
//         count++;
//        }
//     }
// return count;
//  }
// int [] newArray = Creation();
// Print(newArray);
// Console.WriteLine();
// Console.WriteLine("количество простых чисел " + counter(newArray));

// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// int [] CreationN ()
// {
// Console.WriteLine( "Введите размер массива" );
// int lengthM=Convert.ToInt32(Console.ReadLine());
// int [] array = new int[lengthM];
//  for ( int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(1,101);
//    }
//  return array;
// }
//  void Print (int [] array) 
//  {
//     for ( int i=0; i<array.Length; i++)
//     {
//         Console.Write(array[i] + " " );
//     }
//  }
//  bool isRelate (int number) {
// for ( int i=2; i<number; i++)
//     {
//         if (number%10==1 && number%7==0 )
//         {
//             return true;
//         }
//     }
//     return false;
//  }
//  int counter (int [] array) 
//  {
//     int count=0;
//     for ( int i=0; i<array.Length; i++)
//     {
//        if (isRelate(array[i]))
//        {
//         count++;
//        }
//     }
// return count;
//  }
// int [] newArray = CreationN();
// Print(newArray);
// Console.WriteLine();
// Console.WriteLine("количество чисел, которые оканчиваются на 1 и делятся нацело на 7 - " + counter(newArray));

Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.

// Сформируйте целое число, которое будет состоять из цифр из массива.
// Старший разряд числа находится на 0-м индексе, младший – на последнем.

// Пример
// [1 3 2 4 2 3] => 132423 100000 + 30000 + 2000 + 400 + 20 + 3 = 132423
// [2 3 1] => 231
// Console.WriteLine("Введите длину массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = GenerateArray(n);
// PrintArray(array);
// SumNumbersRanks(array);
// int[] GenerateArray(int n)
// {
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
// array[i] = new Random().Next(1, 10);
// }
// return array;
// }

// // int[] array = new int[n];
// // for (int i = 0; i < n; i++)
// // {
// // array[i] = new Random().Next(1, 10);
// // }


// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// }
// // for (int i = 0; i < n; i++)
// // {
// // Console.Write(array[i] + " ");
// // }

// void SumNumbersRanks(int[] array)
// {
// double sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
// sum += array[i] * Math.Pow(10, array.Length - i - 1);
// }
// Console.WriteLine(sum);
// }

// // double sum = 0;
// // for (int i = 0; i < n; i++)
// // {
// // sum += array[i] * Math.Pow(10, n - i - 1);
// // }
// // Console.WriteLine(sum);