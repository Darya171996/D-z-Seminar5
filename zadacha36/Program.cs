// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
// int[] array = new int[6];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 99);
//     Console.WriteLine($"{array[i]}");
// }
// int sum=0;
// sum= array[1]+array[3]+array[5];
// Console.WriteLine(sum);

// Решение через цикл.

int[] array = new int[new Random().Next(0,10)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 99);
    Console.WriteLine($"{array[i]}");
}
int sum=0;
for (int i = 1; i < array.Length; i=i+2)
{
    sum=sum+array[i];
    
}
Console.WriteLine($"{sum} сумма");


