// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*int Degree(int num1, int num2)
{
    int multiply = 1;

    for (int counter = 0; counter < num2; counter++)
        multiply = multiply * num1;

    return multiply;
}

Console.Write("Input a first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Degree(num1, num2);
Console.Write($"{num1} degrees {num2} is {result}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int SumDigits(int num)
{
    int sum = 0;

    for (; num > 0; num = num / 10)
        sum = sum + num % 10;

    return sum;
}

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(num);
Console.Write($"The sum of the digits of the number {num} is {result}");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*int[] CreateArray(int minValue, int maxValue, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}


Console.Write("How many numbers will be in the array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("What is the minimum number in the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("What is the maximum number in the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] yourArray = CreateArray(minValue, maxValue, size);
ShowArray(yourArray);
*/
