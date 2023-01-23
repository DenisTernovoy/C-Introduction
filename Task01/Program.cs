Console.WriteLine("Введите 1-е число:");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число:");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 == num_2 * num_2)
{
    Console.WriteLine("Первое число является квадратом второго.");
} else {
    Console.WriteLine("Первое число НЕ является квадратом второго!");
}