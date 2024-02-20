// Домашнее задание от 19.02.24

// Задача 1 Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 7 и 23.

int num = 21;
int num2 = 7;
int num3 = 23;

if (num % num2 == 0 && num % num3 == 0)
{
    Console.WriteLine("Число кратно и 7 и 23.");
}
else
{
    Console.WriteLine("Число не кратно");
}

// Задача 2: Напишите программу, которая принимает на вход 
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти 
//плоскости, в которой находится эта точка.

int X = 5;
int Y = -9;

if (X > 0 && Y > 0)
{
    Console.WriteLine("в 1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("во 2");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("в 3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("в 4");
}
else
{
    Console.WriteLine("Точка находится на оси координат");
}

//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

int number = 97;
int first = number / 10;
int second = number % 10;

int max = first > second ? first : second;
Console.WriteLine(max);

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

int Natur = 4798;

if (Natur < 10)
{
    Console.Write(Natur);
}
else
{
    while (Natur > 0)
    {
        int current = Natur % 10;
        Natur /=10;
        if (Natur > 0)
        {
            Console.Write(current + ",");
        }
        else
        {
            Console.Write(current);
        }
    }
}