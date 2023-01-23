// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите 1-е число:");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число:");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число:");
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max) {
    max = num_2;
}
if (num_3 > max) {
    max = num_3;
}

Console.WriteLine($"Максимальное число: {max}");