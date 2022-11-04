// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        arr[index] = new Random().Next(-1000,1001);
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

int sum = 0;
 for (int i = 1; i < size; i = i + 2)
 {
    sum = sum + array[i];

 }

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {sum}.");

}

catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}