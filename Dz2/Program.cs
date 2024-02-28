//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arr = new int[10];
Random random = new Random();
int evenCount = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(100, 1000);
    Console.Write(arr[i] + " ");

    if (arr[i] % 2 == 0)
    {
        evenCount++;
    }
}
Console.WriteLine($"\nКоличество четных чисел в текущем массиве: {evenCount}");

//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

int[] numbers = { 1, 3, 5, 6, 7, 8 };
int temp;

Console.Write("Исходный массив: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}

for (int i = 0; i < numbers.Length / 2; i++)
{

    temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

Console.Write("\nПеревернутый массив: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}

