// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// int[]array = GenerateArray();
// turnArray(array);
// int[]GenerateArray()
// {
// int [] array = new int[10];
// for ( int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(1,101);
//     Console.Write(array[i] + " " );
// }
//  Console.WriteLine();
//  return array;
// }

// int[] turnArray(int[]array)
// {
//     int [] array2 = new int[array.Length];
// for ( int i=0; i<array.Length; i++)
// {
//     array2[i]=array[array.Length-1-i];
//     Console.Write(array2[i] + " " );
// }
//  Console.WriteLine();
//  return array2;
// }
// //1. Создание одномерного массива
// //2. Вывод одномерного массива
// //3. Переворот одномерного массива (reverse)

// // int[] GenerateArray(int length)
// // {
// // int[] array = new int[length];
// // for (int i = 0; i < array.Length; i++)
// // {
// // array[i] = Convert.ToInt32(Console.ReadLine());
// // }
// // }

// int[] GenerateArray()
// {
// Console.WriteLine("Введите числа через ,");
// string input = Console.ReadLine(); //"12,24,35,46,13" => ["12", "24" , "35" , "46" , "13"] => [12, 24, 35, 46, 13]
// string[] arrayNumbers = input.Split(",");
// int[] numbers = new int[arrayNumbers.Length];
// for (int i = 0; i < arrayNumbers.Length; i++)
// {
// numbers[i] = Convert.ToInt32(arrayNumbers[i]);
// }
// return numbers;
// }

// void PrintArray(int[] array)
// { //[12, 24, 35, 46, 13] => "12 24 35 46 13"
// string str = String.Join(" ", array); //String.Join => Трансформирует массив в строку
// Console.WriteLine(str);

// foreach (int number in array)
// { //foreach - перебирает каждый элемент итерируемого объекта, в данном случае массив чисел - array
// Console.Write(number + " ");
// }
// }

// void ReverseArray(int[] array)
// {
// int temp;
// int lastIndex = array.Length - 1;
// for (int i = 0; i < array.Length / 2; i++)
// {
// temp = array[i];
// array[i] = array[lastIndex - i];
// array[lastIndex - i] = temp;
// }
// }

// int[] array = GenerateArray();
// PrintArray(array);
// ReverseArray(array);
// Console.WriteLine();
// PrintArray(array);

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
// if(array[0] < array[1] + array[2] &&)...
// int[] GenerateArray()
// {
// string[] str;
// Console.WriteLine("Введите 3 числа через , ");
// str = Console.ReadLine().Split(",");

// int[] array = new int[str.Length];
// for (int i = 0; i < str.Length; i++)
// {
// array[i] = Convert.ToInt32(str[i]);
// }

// return array;
// }


// void CheckTriangle(int[] array)
// {
// int summa = 0;
// for(int i = 0; i < array.Length; i++)
// {
// summa += array[i];
// }

// for(int i = 0; i < array.Length; i++)
// {
// if(array[i] >= summa - array[i])
// {
// Console.WriteLine("Error!");
// return;
// }

// }
// Console.WriteLine("Треугольник с такими сторонами может существовать");
// }


// int[] array = GenerateArray();
// CheckTriangle(array);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// int CountFibonacci()
// {
// Console.Write("Введите количество чисел для вывода Фибоначчи: ");
// int number = Convert.ToInt32(Console.ReadLine());

// return number;
// }


// int[] NumbersFibonacci(int number)
// {
// int[] array = new int[number];
// array[0] = 0;
// array[1] = 1;
// for(int i = 2; i < array.Length; i++)
// {
// array[i] = array[i-1] + array[i-2];
// }

// return array;
// }


// //int number = CountFibonacci();
// //int[] array = NumbersFibonacci(CountFibonacci());

// Console.WriteLine(String.Join(" ", NumbersFibonacci(CountFibonacci())));