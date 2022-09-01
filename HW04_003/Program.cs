// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Masss()
{
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Massiv = new int[n];
for(int i = 0; i < Massiv.Length; i++)      // заполнили случайными цифрами массив
    {
        Massiv[i] = new Random().Next(1,100);
        Console.Write($"{Massiv[i]}, ");
    }
}
Masss();
