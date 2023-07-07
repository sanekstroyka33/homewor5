// int[] array = GetArray(8); //количество выводимых в массиве элементов
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int even = 0;

// foreach(int el in array)
// {
//     even += el % 2 == 0 ? 1 : 0;
// }

// Console.WriteLine($"Четных чисел в массиве: {even}");

// //заполнение массива
// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(100, 1000);
//     }
//     return result;
// }
// int[] array = GetArray(7);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int summ = 0;
// int el = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         el = array [i];
//         summ += el;
//     }
// }

// Console.WriteLine($"Сумма элементов нечетных индексов массива = {summ}");

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(-10, 10);
//     }
//     return result;
// }
// int[] array = GetArray(10); 
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int max = array.Max();
// int min = array.Min();

// int dif = max - min;

// Console.Write($"Max = {max}, Min = {min}, Разница = {dif}");

// //заполнение массива
// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(10, 100);
//     }
//     return result;
// }