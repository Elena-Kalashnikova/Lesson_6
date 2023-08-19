// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
// каждая сторона треугольника меньше суммы двух других сторон

Console.WriteLine("Введите число 1");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int number_3 = Convert.ToInt32(Console.ReadLine());

bool CheckSidesTriangle(int num_1, int num_2, int num_3)
{
    // int sum_1 = num_2 + num_3;
    // int sum_2 = num_1 + num_3;
    // int sum_3 = num_1 + num_2;
    // if (num_1 < sum_1 && num_2 < sum_2 && num_3 < sum_3)
    // {
    //     return true;
    // }
    // return false;
    return num_1< num_2+num_3 && num_2< num_1+num_3 && num_3<num_1+num_2;



}

bool result = CheckSidesTriangle(number_1, number_2, number_3);
Console.WriteLine(result ? "Да" : "Нет");