
// Задача 34. Задайте массив заполненных случайных чисел трехзначными числами. Напишите программу, которая показывает количество чётных чисел в массиве

// Console.WriteLine("введите длинну массива");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[len];
// int sum = 0;
// void Napolnenie(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] = new Random().Next(100, 1000);
//     }
//     for (int s = 0; s < mas.Length; s++)
//     {
//         Console.Write($" {mas[s]}");
//     }

//     Console.WriteLine();
// }
// Napolnenie(array);

// for (int i = 0; i < array.Length; i++)
// {
// if (array[i]%2==0)
// {
//     sum+=1;
// }
// }
// Console.WriteLine($"колличество чётных чисел в массиве {sum}");






// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Console.WriteLine("введите длинну массива");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[len];
// int sum = 0;
// void Napolnenie(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] = new Random().Next(0, 10);
//     }
//     for (int s = 0; s < mas.Length; s++)
//     {
//         Console.Write($" {mas[s]}");
//     }

//     Console.WriteLine();
// }
// Napolnenie(array);

// for (int i = 1; i < array.Length; i=i+2)
// {
//     sum+=array[i];
// }
//  Console.WriteLine($"сумма элементов, стоящих на нечётных позициях в массиве равна {sum}");