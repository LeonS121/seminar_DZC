// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// // 3, 5 -> 243 (3⁵)

// // 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b=Convert.ToInt32(Console.ReadLine());

    int result = 1;
    for (int i = 1; i <= b; i++)
        {
            result = result * a;
        }
    Console.WriteLine(result);

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// // 452 -> 11

// // 82 -> 10

// // // 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number=Convert.ToInt32(Console.ReadLine());
// int len = NumLen(number);
// SumNum(number, len);

// int NumLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// void SumNum(int number, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     Console.WriteLine(sum);
// }

// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// // 6, 1, 33 -> [6, 1, 33]


// int[] NumArr = new int[8];
// int i; 

// Console.WriteLine("Введите массив чисел: ");
    
//     for (i = 0; i < 8; i++)
//         {
//         NumArr[i] = int.Parse(Console.ReadLine());
//         }
 
// Console.WriteLine(String.Join(", ",NumArr));

