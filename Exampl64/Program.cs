//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
//M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"

void Recursion(int m1, int n1)
{
    if (m1 > n1) return;
    if ( m1 % 3 == 0)
    Console.Write(m1 + " ");
    m1++;
    Recursion(m1, n1);
}
void Zadacha64()
{
    Console.WriteLine("Введите число m  ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n  ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"M = {m}, N = {n}");
    Recursion(m, n);
}
Zadacha64();