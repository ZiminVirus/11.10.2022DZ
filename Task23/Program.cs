// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void CubingTables (int number)
{
    int i=1;
    Console.WriteLine ($"Таблица кубов чисел от 1 до {number}");
    while (i<=number)
    {
        Console.WriteLine ($"|{i,6})| {Math.Pow(i,3),6}|");
        i++;
    }
}

Console.WriteLine ("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());
CubingTables (num);
