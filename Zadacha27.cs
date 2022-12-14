/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

 Console.Write("Введите число: ");
 int num = int.Parse(Console.ReadLine()!);
 Console.WriteLine($"Сумма цифр = {SumNums(num)}");

 int SumNums(int number)
 {
    int sum = 0;
    while (Math.Abs(number)%10>0 || Math.Abs(number)/10>0) //Для случаев, когда одна из цифр равна 0
    {
        sum = sum + Math.Abs(number)%10;
        number = number/10;
    }
    return sum;
 }