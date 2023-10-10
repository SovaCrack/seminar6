// Напишите программу, которая будет создавать копию
//заданного массива с помощью поэлементного копирования.

int [] CopyArray( int[] array)
{
int[] arrayCopy = new int [array.Length];
for (int i = 0; i < arrayCopy.Length; i++)
{
    arrayCopy[i] = array[i];
    Console.Write($"{arrayCopy[i]} ");
}
return arrayCopy;
}

int[] array1 = new int [] {1,2,3,4,5,6};
CopyArray(array1);