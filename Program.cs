// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// System.Console.WriteLine(" введите размер массива...");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// System.Console.WriteLine();
// PrintArray(numbers);
// int count = 0;
// for( int i = 0; i< numbers.Length; i++){
//     if(numbers[i]%2==0){
//         count++;
//     Console.WriteLine($" четное число, {count}");}
// }
// void FillArrayRandomNumbers(int[] numbers){
//     for( int i = 0; i< numbers.Length; i++){
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers){
//     for(int i=0; i<numbers.Length; i++){
//         System.Console.WriteLine(numbers[i]+ ",");
//     }
//     System.Console.WriteLine();
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int summOddIndicies(int[] arr)
// {
//     int summ = 0;
//     for (int index = 1; index < arr.Length; index = index + 2)
//     {
//         summ += arr[index];
//     }
//     return summ;
// }
// Console.WriteLine("Введите значение количество элементов массива");
// int size = Convert.ToInt32(Console.ReadLine());

// if (size < 1)
// {
//     Console.WriteLine("Некорректное значение");
// }
// else
// {
//     int[] arr = new int[size];
//     for (int index = 0; index < size; index++)
//     {
//         arr[index] = new Random().Next(-99, 100); // В задание не указано, но если судить по примеру, значения [-99, 99]
//     }
//     Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + summOddIndicies(arr));
// }

