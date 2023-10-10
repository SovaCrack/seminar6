// Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Write("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива ");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива ");
int maxArr = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
      Console.Write($"{arr[i]} \t");  
    }
    Console.Write("\b\b\b\b\b\b]");
    Console.WriteLine();
}

int[] GenArr(int n, int min, int max)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().Next(min, max +1); 
    }
    return arr;
}

int[] ReversArry(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
      int temp =arr[i];
      arr[i] = arr[arr.Length -1 - i];
      arr [arr.Length -1 - i] = temp;
    }
    return arr;
}
 int[] arry = GenArr(n, minArr, maxArr);
 PrintArray(arry);

 int[] arry_revers = ReversArry(arry);
 PrintArray(arry_revers);