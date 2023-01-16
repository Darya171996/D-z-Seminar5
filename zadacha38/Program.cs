// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 99);
    Console.WriteLine($"{array[i]}");
}

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}
Console.WriteLine($"{max} максимальный элемент");
Console.WriteLine($"{min} минимальный элемент");
int sum=(max-min);
Console.WriteLine(sum); 