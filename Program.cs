// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int InputNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] randomArray()
{
    int sizeArr = InputNumber("Введите размер массива: ");
    int[] numbers = new int[sizeArr];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
    return numbers;
}
int[] arr = randomArray();

int result = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
    {
        result += arr[i];
    }
}
Console.Write("Сумма нечётных позиций в массиве: [{0}] = ", string.Join(", ", arr));
Console.WriteLine(result);