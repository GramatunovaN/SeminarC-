//Задайте массив. 
//Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.
//int [] array = {2,5,7,4,4};
int [] array = new int[5];
Console.WriteLine("Введите число от 1 до 10");
int number = Convert.ToInt32(Console.ReadLine());
bool isEqual = false;
for ( int i=0; i<array.Length; i++)
{
    array[i]=new Random().Next(1,11);
    Console.Write(array[i] + " ");
     if (array [i]==number)
{ 
    isEqual = true;
}
}
   Console.WriteLine();
 if (isEqual)
{ 
Console.WriteLine("Да");
}
else
{ 
Console.WriteLine("Нет");
}