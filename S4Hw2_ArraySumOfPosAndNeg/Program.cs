// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива.
Console.Clear();
int[] arr = new int[12];
int sumPos = 0;
int sumNeg = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,10); // В данном диапазоне по условию задачи не будет отрицательных элементов!
    Console.Write($"{arr[i]} ");
    if (arr[i] > 0) sumPos = sumPos + arr[i];
    //Условие суммирования отрицательных элементов записал несмотря на диапазон по условию задачи
    else if (arr[i] < 0) sumNeg = sumNeg + arr[i]; 
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна {sumPos}!");
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumNeg}!");