// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
try
{

Console.Write("Укажите размер массива (введите натуральное число): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void FillArray(int[] arr)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(100,1000);
        index++;
    }
}
void PrintArray(int[] arr)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
FillArray(array);
PrintArray(array);

int num = 0;
 for (int i = 0; i < size; i++)
 {
    if (array[i] % 2 == 0) 
    {
        num++;
    }
 }

Console.WriteLine($"Количество четных чисел в данном массиве: {num}.");

}

catch
{

    Console.WriteLine("Ошибка! Введите натуральное число.");

}