// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


try
{

Console.Write("Укажите размер массива (введите натуральное число): ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

void FillArray(double[] arr)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = Convert.ToDouble (new Random().Next(-1000,1001)) / 10;
        index++;
    }
}
void PrintArray(double[] arr)
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

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"Максимальный элемент массива: {max}, минимальный элемент массива: {min}, разница между максимальным и минимальным элементами составляет {max - min}.");

}

catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}