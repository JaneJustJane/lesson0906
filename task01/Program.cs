// Написать программу возведения целого числа А в целую степень В (с помощью рекурсии)

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите степень В, в которую возвести число А: ");
int b = int.Parse(Console.ReadLine()?? "0");

int Power(int a, int b)
{
    if (b==0) return 1;
    else return Power(a,b-1)*a;
}
Console.WriteLine(Power(a,b));