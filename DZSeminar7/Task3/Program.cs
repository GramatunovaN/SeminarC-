// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
Console.Write("Введите длину массива - ");
int aL =Convert.ToInt32(Console.ReadLine());

int [] Creation ()
{
int [] array = new int[aL];
 for ( int i=0; i<aL; i++)
{
    array[i]=new Random().Next(1,101);
   }
 return array;
}
 void Print (int [] array) 
 {
    for ( int i=0; i<aL; i++)
    {
        Console.Write(array[i] + " " );
    }
 }
int []array= Creation();
Print(array);
Console.WriteLine(" ");
Function(array,aL);
void Function(int []array, int aL)
{ 
    if(aL==0)
    { 
        return;
    }
    Console.Write(array[aL-1] + ", ");
    Function(array,aL-1);
}