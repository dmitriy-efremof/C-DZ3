// Задача 19___________________
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num%10;
// int num2 = num%100;
// int num3 = num/1000;
// int num4 = num/10000;
// int twor = num2/10; //Данная переменная определяет значение второй цифры в пятизначном числе, начиная с правой части
// int twol = num3%10; //Данная переменная определяет значение второй цифры в пятизначном числе, начиная с левой части

// if ((num > 10000) && (num < 100000))
// {
//     if ((num1 == num4) && (twor == twol))
//     {
//         Console.WriteLine($"{num} - Является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"{num} - Не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Число не пятизначное, повторите ввод");
// }

// Задача 21___________________
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53 

// d = ((X2-X1)2 + (Y2-Y1)2 + (Z2-Z1)2)2

// Console.Write("Введите значение для точки (А) X1: ");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение для точки (А) Y1: ");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение для точки (А) Z1: ");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение для точки (B) X2: ");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение для точки (B) Y2: ");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение для точки (B) Z2: ");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));

// Console.WriteLine($"Расстояние между точками в 3D пространстве = {d}");

// Задача 23___________________
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = 1;

// if (N < 0)
// {
//     Console.WriteLine("Число не может быть отрицательным, повторите ввод: ");
// }

// while (N >= i)
// {
//     Console.Write(Math.Pow(i,3) + " ");
//     i = i + 1;    
// }
