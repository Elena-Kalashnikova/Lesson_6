// Не используя рекурсию вывести первые n чисел Фиббоначи
// первые два числа Ф 0 и 1
// 5 = 01123



int[] Fibbonacci(int num)
{
    int[] arr = new int[num];
    arr[1] = 1;

    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

    Console.WriteLine("]");
}

Console.WriteLine("Введите число N:");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 2)
{
    Console.WriteLine("Ввели неверное число N");
    return;
}

// int[] array = Fibbonacci(size);
PrintArray(Fibbonacci(size));
