// Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

bool CheckTriangle(int a, int b, int c)
{
    if (a < b + c && b < c + a && c < b + a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

    

Console.Write("Введите номер А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер В: ");;
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер С: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result: {CheckTriangle(a, b, c)}");