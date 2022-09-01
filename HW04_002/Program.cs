// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNum()
{
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while (x > 0)
            {
                s = s + x % 10;
                x = x /10 ;
            }
            return s;
 // Console.WriteLine("Sum = " + s);
}
Console.WriteLine (SumNum());


// Console.WriteLine("Введите число: ");
// string x = Console.ReadLine();
// int sum = 0;
// for (int i = 0; i < x.Length; i++)
// {
//     int number = Convert.ToInt32(x[i].ToString());
//     sum = sum + number;   //    sum += number;
// }
// Console.WriteLine (sum);
