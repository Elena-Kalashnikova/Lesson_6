
// Задача 42 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 46 -> 101110

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
//int binintdec = DecimaltoBinary(number);
Console.WriteLine($"Десятичное число преобразованное в двоичное = {DecimaltoBinary(number)}");

// int DecimaltoBinary(int num)
// {
//     int count = 0;
//     int basedec = 1;
//     while (num > 0)
//     {
//         count += num % 2 * basedec;
//         num /= 2;
//         basedec *= 10;

//     }
//     return count;
// }

string DecimaltoBinary(int num)
{
    string count = string.Empty;
    while (num > 0)
    {
        count = num % 2 + count;
        num /= 2;


    }
    return count;
}