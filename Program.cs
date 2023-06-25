/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int Exponentiation(int num1, int num2)
{
  int result = 1;
  for(int i=1; i <= num2; i++){
    result = result * num1;
  }
    return result;
}
bool Validation (int num2)
{
    if (num2 < 0)
    {
    Console.Write($"Число не должно быть меньше нуля");
    return false;
    }

return true;
}

  Console.Write("Введите первое число: ");
  int num1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число: ");
  int num2 = Convert.ToInt32(Console.ReadLine());

  if (Validation(num2))
{
  int exponentiation = Exponentiation(num1, num2);
  Console.WriteLine($"Число {num1} в степени {num2} равно {exponentiation}");
}

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int SumNumber(int number)
{
    int count = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;

}
int number = InputNum("Введите целое число: ");
int sum = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] GenerateArray (int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
    array[i] = new Random().Next(min, max +1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}


int len = InputNum("Введите длину массива: ");
int min = InputNum("Введите начальное значение: ");
int max = InputNum("Введите конечное значение: ");
int[] arr = GenerateArray(len, min, max);
PrintArray(arr);
