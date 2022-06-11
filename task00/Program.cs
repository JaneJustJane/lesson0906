// Найти сумму цифр числа с помощью рекурсии

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()?? "0");
int amount = 0;



int Sum (int n)
{
    if (n%10 == 0) return n%10;
    else  Sum (n/10);
    amount = amount + n%10;
    return amount;
}

Sum(n);
Console.WriteLine (amount);

