//Задача #1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//int[] CreateArr(int size)
//{
   // int[] array = new int[size];

   // for(int i = 0; i < size; i++) 
  //      array[i] = new Random().Next(100, 1000);
    
  //  return array;
//}

//int PositivNum(int[] array)
//{   
   // int numbers = 0;
   // for (int j = 0; j < array.Length; j++)
   //     if (array[j] % 2 == 0)
   //         numbers++;
  //  return numbers;
//}

//void ShowArray(int[] array)
//{
    //for(int i = 0; i < array.Length; i++)
   //     Console.Write(array[i] + " ");
   // Console.WriteLine();
//}

//Console.Write("Укажите размер массива: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] showArr = CreateArr(size);
//ShowArray(showArr);
//Console.WriteLine(PositivNum(showArr));

// Задача #2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//double[] CreateArr(int size, int min, int max)
//{
    //double[] array = new double[size];

    //for(int i = 0; i < size; i++) 
    //    array[i] = Math.Round(new Random().NextDouble() + new Random().Next(min, max), 2);
    
    //return array;
//}

//double SumNum(double[] array)
//{
    //double total = 0;
    //for (int j = 1; j < array.Length; j += 2) 
      //  total += array[j];
    
   // return Math.Round(total, 2);
//}
//
//void ShowArray(double[] array)
//{
   // for(int l = 0; l < array.Length; l++)
   //     Console.Write(array[l] + " ");
   // Console.WriteLine();
//}

//Console.Write("Введите размер массива: ");
//int size = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите минимальное значение массива: ");
//int min = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите максимальное значение массива: ");
//int max = Convert.ToInt32(Console.ReadLine());

//double[] showArr = CreateArr(size, min, max);
//ShowArray(showArr);

//Console.WriteLine(SumNum(showArr));

 //*Задача #3.  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//double[] CreateArr(int size, int min, int max)
//{
   // double[] array = new double[size];

  //  for(int i = 0; i < size; i++) array[i] = Math.Round(new Random().NextDouble() + new Random().Next(min, max), 2);
    
   // return array;
//}

//void searchNum(double[] array)
//{

   // double min_num = array[0];
    //double max_num = array[0];

   // for(int j = 0; j < array.Length; j++)
   // {
       // if (min_num > array[j])
        //    min_num = array[j];