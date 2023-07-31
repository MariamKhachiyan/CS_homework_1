// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// вводим три числа
// сравниваем
// выводим максимальное

Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third name: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int a = number1;
int b = number2;
int c = number3;
int max = a;

if (b > max ) max = b;
if (c > max ) max = c;

Console.WriteLine($"max= {max}");
