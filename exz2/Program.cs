// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int negativSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array [i];
    }
    return sum;
}
int len = ReadInt("Введите длину массива");
int minRnd = ReadInt("Введите границу минимума случайной ведичины");
int maxRnd = ReadInt("Введите границу максимума случайной ведичины");
int[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
int per;
per = negativSum(array);
System.Console.WriteLine($"Сумма чисел на нечётных позициях в массиве  ");
System.Console.WriteLine($"{per}");