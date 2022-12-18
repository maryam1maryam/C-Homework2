
//Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

num = num / 10 % 10;

Console.WriteLine($"Вторая цифра введенного числа: {num}");*/

//Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*int NumDigit(int num)
{
    int result = -1;
    if (num >= 100)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
    return result;
}
Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int newNum = NumDigit(Num);
Console.WriteLine($"Третья цифра числа {Num} - {newNum}");*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.Write ("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 >= 1 && num1 <=5) System.Console.WriteLine("рабочий день");
else
if (num1 == 6 || num1 ==7 ) System.Console.WriteLine("выходной");
else System.Console.WriteLine("такого дня не существует");*/



