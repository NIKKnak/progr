//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// using static System.Console;
// Clear();
// WriteLine("Введите размер массива ");
// int a = int.Parse(ReadLine()!);
// int[] array = razmer(a);
// WriteLine();
// printArray(array);
// WriteLine($"количество четных чисел = {delenie(array)}");



// int[] razmer(int mas)
// {


//     int[] result = new int[mas];
//     for (int i = 0; i < mas; i++)
//     {
//         result[i] = new Random().Next(100,1000);
//     }  
//     return result;
    
// }


// void printArray(int[] mas1)
// {
    

//     string FinalString = "[ ";
//     foreach (int i in mas1
// )
//     {
//         FinalString+=$"{i} ";
//     }
//     FinalString += "]";
//     WriteLine(FinalString);

// }


// int delenie(int[] mas2)
// {

//     int result = 0;
//     for (int i = 0; i < mas2.Length; i++)
//     {
//        if(mas2[i]%2==0)
//        {
//         result++;
//        }

//     }
//     return result;
// }





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// using static System.Console;
// Clear();
// WriteLine("введите размер массива");
// int a = Convert.ToInt32(ReadLine()!);
// int[] array = GetArray(a);
// printArray(array);
// WriteLine($"Сумма элементов, стоящих на нечётных позициях = {NaytiSimmu(array)}");



// int[] GetArray(int massiv)
// {
//     int[] result = new int[massiv];
//     for (int i = 0; i < massiv; i++)
//     {
//         result[i] = new Random().Next(-99,100);
//     }
//     return result;
// }


// int NaytiSimmu(int[] massiv)
// {
//     int sum =0;
//     for (int i = 0; i < massiv.Length; i++)
//     {
//         if(i%2 ==0)
//         {
//             sum = sum + massiv[i];
//         }
//     }

//     return sum;
// }


// void printArray(int[] mas1)
// {
    

//     string FinalString = "[ ";
//     foreach (int i in mas1
// )
//     {
//         FinalString+=$"{i} ";
//     }
//     FinalString += "]";
//     WriteLine(FinalString);

// }









// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// using static System.Console;
// Clear();
// WriteLine("введите размер массива");
// int a =  int.Parse(ReadLine()!);
// int[] array = GetArray(a);
// printArray(array);
// WriteLine($"Разница максимального и минимального числа = {raznica(array)}");

// int[] GetArray(int massiv)
// {
//     int[] result =new int[massiv];
//     for (int i = 0; i < massiv; i++)
//     {
//         result[i] = new Random().Next(0,100);
//     }
//         return result;
// }

// void printArray(int[] massiv)
// {
//      Write("[");
//     for (int i = 0; i < massiv.Length; i++)
//     {
//         Write($" {massiv[i]}");
//     }
//     Write(" ]");
// }

// int raznica(int[] razn)
// {
//     int result = 0;
//     int max = razn[0];
//     int min = razn[0];

//     for (int i = 1; i < razn.Length; i++)
//     {
//     if (razn[i]>max) max = razn[i];
//     if (razn[i]<min) min = razn[i];
//     }
//     result = max - min;
//     return result;
// }