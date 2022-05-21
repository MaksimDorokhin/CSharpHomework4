// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел.
Console.Clear();
int[] arr = new int[8];
int countEven = 0;
int countOdd = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100,1000); 
    Console.Write($"{arr[i]} ");
    if (arr[i] % 2 == 0) countEven++;
    else countOdd++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных элементов массива равно {countEven}!");
Console.WriteLine($"Количество нечетных элементов массива равно {countOdd}!");