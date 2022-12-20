//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Linear (double k1, double b1, double k2, double b2){
      double x = Math.Round(((b2 - b1) / (k1 - k2)),2);
      Console.Write(x);
      double y = Math.Round(((k2 * x) + b2),2);
      Console.WriteLine ($"Пересечение в точке: ({x}; {y})");
      
    }


    Console.Write("Введите значение b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите значение b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
   

   Linear(k1,b1, k2, b2);
// тут есть логическая ошибка , нужно дороботать 
//double [] Linear(double b1, double b2, double k1, double k2)
// {  
//     double [] array = new double [2] ;//создаем массив из 2 элементов
//      array[0] = (b2 - b) / (k1 -k2); // Нашли X
//       array[1] = k1* array[0] + b1; // Нашли Y
 
//     return array ;
// }
// Console.Write("введите значение b1:="); 
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите значение k1:=");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите значение b2:=");
// double b_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите значение k2:=");
// double k_2 = Convert.ToInt32(Console.ReadLine());
//  double [] array = Linear (b1,k1,b2,k2); // Запускаем Фунцкию 
// Console.WriteLine($"Точки пересечения прямых: X:{Math.Round (array[0],1)} Y:{Math.Round (array[1],1)}");
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3




// Console.Write("введите размер массива :  ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] CreateArray(int m){int[] array = new int[m];
//     for(int i = 0; i < m; i++){Console.Write($"введите эелмент массива  {i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// int[] arr = CreateArray(m);

// void PrinArray(int[] arr){
//     for(int i = 0; i < arr.Length; i++){Console.Write($"{arr[i]}, ");
//     }
// }
// PrinArray(arr);
// void Count(int[] arr){int count = 0;
//     for(int i = 0; i < arr.Length; i++){if(arr[i] > 0){count++;
//     }
//     Console.Write($"-> {count}");
// }
// }
// Count(arr);