// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumDigits(int number)
{
  int digit =0;
  while(number>0)
  {
    digit=digit+number%10;
    number=number/10;
  }
return digit;
};
Console.Write("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(number));
