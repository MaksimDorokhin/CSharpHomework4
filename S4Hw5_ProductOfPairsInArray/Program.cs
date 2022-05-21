// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();
Console.Write("Введите кол-во элементов одномерного массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[length];
int[] result = new int[length / 2];
for (int i = 0; i < length; i++)
{
    arr[i] = new Random().Next(-9, 10);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.WriteLine("Произведения пар чисел:");
for (int i = 0; i < length / 2; i++)
{
    result[i] = arr[i] * arr[length - 1 - i];
    Console.Write($"{result[i]} ");
}
Console.WriteLine();