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

// Console.WriteLine("Введите число для проверки");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 < 10)
// Console.WriteLine("Такой цифры нет");
// else
// {
//     // int num2 = 0;
//     while (num1 >= 99)
//     {
//         num1 = num1 / 10;
//     }
//     num1 = num1 % 10;
//     Console.WriteLine(num1);
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
//выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число для проверки");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 < 1000 & num1 > 99 )
// {
//     num1 = num1 / 10;
//     num1 = num1 % 10;
//     Console.WriteLine($"Второе число равно {num1}");
// } 
// else
//     Console.WriteLine("Введите трёхзначное число для проверки");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Введите число для проверки");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 < 99 )
// Console.WriteLine("В числе нет третьей цифры");
// else
// {
//     while (num1 > 999 ) 
//     {
//         num1 = num1 / 10;
//     }
//     Console.WriteLine(num1 % 10);
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число недели для проверки");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 > 7 )
// Console.WriteLine("Введённое число не корректное");
// else
// {
//     if (num1 < 6)
//     Console.WriteLine("Этот день будний");
//     else
//     Console.WriteLine("Этот день выходной");
// }



// void CheckKoord(int x, int y)
// {
// if (x > 0 && y > 0)
// Console.WriteLine("Это четверть № 1");
// else if (x > 0 && y < 0)
// Console.WriteLine("Это четверть № 4");
// else if (x < 0 && y < 0)
// Console.WriteLine("Это четверть № 3");
// else if (x < 0 && y > 0)
// Console.WriteLine("Это четверть № 2");
// else
// Console.WriteLine("Точка лежит на координатной оси");
// }

// int CheckKoord2(int x, int y)
// {
// int result = 0;
// if (x > 0 && y > 0)
// result = 1;
// else if (x > 0 && y < 0)
// result = 4;
// else if (x < 0 && y < 0)
// result = 3;
// else if (x < 0 && y > 0)
// result = 2;
// return result;
// }




// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x,y);



// void CheckKoord(int x)
// {
//     int i = 1;
//     while (i < x+1)
//     {
//         Console.WriteLine(i*i);
//         i ++;
//     }

// }






// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x);


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void CheckKoord(int x)
{
    if ((9999 <= x) &  (x < 99999))
    {
   if ((x / 10000 == x % 10) & (x / 1000 % 10 == x % 100 / 10))
    Console.WriteLine("DA");
   else
   Console.WriteLine("NET");
    }
    else 
    Console.WriteLine("Число не пятизначное");
}


Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
CheckKoord(x);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CheckKoord(int num)
// {
//     int i = 1;
// double resault = 0;
// while (i <= num)
// {
//     resault = (Math.Pow(i,3));
//     Console.Write($" {resault}");
//     i++;
// }
// }

// Console.WriteLine("Введите любое число:");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckKoord(num);

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Rast(double x1, double y1, double x2, double y2, double z1, double z2)
// {
// return Math.Sqrt((Math.Pow(x2 - x1,2)) + (Math.Pow(y2 - y1,2)) + (Math.Pow(z2 - z1,2)));
// }


// Console.WriteLine("Введите Координату x1 для точки А");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y1 для точки А");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату z1 для точки А");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату x2 для точки B");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y2 для точки B");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату z2 для точки А");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Расстояние между двяму точками равно: {Math.Round(Rast(x1,y1,x2,y2,z1,z2),3)}");
