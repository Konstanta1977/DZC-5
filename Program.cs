// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.WriteLine(" введите размер массива...");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine();
PrintArray(numbers);
int count = 0;
for( int i = 0; i< numbers.Length; i++){
    if(numbers[i]%2==0){
        count++;
    Console.WriteLine($" четное число, {count}");}

}

void FillArrayRandomNumbers(int[] numbers){
    for( int i = 0; i< numbers.Length; i++){
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers){

    for(int i=0; i<numbers.Length; i++){
        System.Console.WriteLine(numbers[i]+ ",");
    }

    System.Console.WriteLine();
}