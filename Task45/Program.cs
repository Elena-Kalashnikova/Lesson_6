// Задача 45 
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int[] CopyArray(int[] arr){
int[] newArray = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    newArray[i] = arr[i];
}
return newArray;
}


int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int[] newarray = CopyArray(array);
//newarray[0]=1000;
PrintArray(newarray);

