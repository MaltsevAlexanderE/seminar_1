// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32( Console.ReadLine()) ;
// int result = num * num;
// Console.WriteLine(result);

// if (num>0)
// {
// Console.WriteLine("Было введено положительное число");
// }
// else if (num==0)
// Console.WriteLine("Был введен ноль");
// else
// Console.WriteLine("Было введено отрицательное число");

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите 2 числа");
// int num1 = Convert.ToInt32( Console.ReadLine()) ;
// int num2 = Convert.ToInt32( Console.ReadLine()) ;
// if (num1 == num2)
// Console.WriteLine("Введённые числа одинаковые");
// else if (num1 < num2) 
// Console.WriteLine("max " + num2);
// else
// Console.WriteLine("max " + num1);

// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите 3 числа");
// int num1 = Convert.ToInt32( Console.ReadLine()) ;
// int num2 = Convert.ToInt32( Console.ReadLine()) ;
// int num3 = Convert.ToInt32( Console.ReadLine()) ;
// int max = 0;
// if (num1 == num2 & num1 == num3)
// Console.WriteLine("Введённые числа одинаковые");
// else if (num1 > num2) 
// max = num1;
// else if (num2 > num3) 
// max = num2;
// else
// max = num3;
// Console.WriteLine("max " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число для проверки");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 == 0)
// Console.WriteLine("Число равно нулю");
// else
// {
// int ostatok = num1 % 2;
// if (ostatok == 0)
// Console.WriteLine("Введённое число чётное");
// else 
// Console.WriteLine("Введённое число нечётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число для проверки");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 == 0)
// Console.WriteLine("Число равно нулю");
// else
// {
// int i = 2;
// while (i <= num1)
// {
// if (i % 2 == 0)
// Console.Write(i + " ");
// i = i + 2;
// }
// }

// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая 
// принимает на вход целое число любой разрядности и на выходе показывает вторую цифру 
// слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

Console.WriteLine("Введите число для проверки");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 10)
Console.WriteLine("Такой цифры нет");
else
{
    // int num2 = 0;
    while (num1 >= 99)
    {
        num1 = num1 / 10;
    }
    num1 = num1 % 10;
    Console.WriteLine(num1);
}