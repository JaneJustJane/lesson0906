// Показать первые N чисел, для которых каждое следующее = суммме двух предыдущих
// Первые 2 элемента последовательности задаются пользователем. 

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число В: ");
int b = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите количество чисел N: ");
int n = int.Parse(Console.ReadLine()?? "0");
Console.Write($"{a} ");

string SUM(int a, int b, int n)
{
    Console.Write($"{b} ");
    if (n==2) return String.Empty;
    else return SUM(b, a+b, n-1);
}
SUM(a,b,n);