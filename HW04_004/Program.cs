// необязательная задача 
// Написать программу сортировки массива от большего к меньшему. 
// Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Massiv = new int[n];
int temp = 0;
Random r = new Random();
for(int i = 0; i < Massiv.Length; i++)      // заполнили случайными цифрами массив
    {
    Massiv[i] = r.Next(1,100);    //   массив заполняется рандомно из "r"
    Console.Write($"{Massiv[i]}, ");
        }
        for (int i = 0; i < Massiv.Length - 1; i++)
                for (int j = i + 1; j < Massiv.Length; j++)
                if (Massiv[i] < Massiv[j]) 
                {
                temp = Massiv[i];
                Massiv[i] = Massiv[j];
                Massiv[j] = temp;
                }
                Console.WriteLine();
                foreach(int number in Massiv)   // вывод элементов из массива
        {
            // Console.Write("отсортированно - ");
            Console.Write($" " +number);
    }
            