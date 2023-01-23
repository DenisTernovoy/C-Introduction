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

