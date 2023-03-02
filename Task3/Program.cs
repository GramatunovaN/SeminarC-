// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите порядковый номер дня недели");
int numberA = Convert.ToInt32(Console.ReadLine());
string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
int n = 7;
int index = 0;
while ( index < n)
{
    if (index== numberA-1)
    {
        Console.WriteLine(days[index]);
    }
    index++;
}
