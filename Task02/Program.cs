// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите 1-е число:");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число:");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2) {
    Console.WriteLine($"Число {num_1} больше {num_2}");
} else if (num_2 > num_1) {
    Console.WriteLine($"Число {num_2} больше {num_1}");
} else {
    Console.WriteLine($"Число {num_2} равно {num_1}");
}

