// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
double newn = 0;
while (n >= 1)
{
    newn = n % 2 * Math.Pow(10, count) + newn;
    n = n / 2;
    count++;
   
}
Console.WriteLine(newn);