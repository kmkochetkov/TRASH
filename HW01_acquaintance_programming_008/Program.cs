//Программа, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N:");
int number = int.Parse(Console.ReadLine());
int numberT = 2;
//Console.Write("Введите число для проверки на чётность: ");
//int number = int.Parse(Console.ReadLine());

Console.Write($"Чётные числа в диапазоне [1 - {number}] : ");

while (numberT < number)
{
    Console.Write($" {numberT}");
    numberT = (numberT+2);
}
Console.WriteLine();