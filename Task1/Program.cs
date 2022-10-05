// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4


int M = new Random().Next(4, 11);

Console.Write($"Выберите способ решения 1 - ввод от пользоваеля, 2 - с помощью генератора случайных чисел --> ");

int answer = int.Parse(Console.ReadLine()!);

if (answer == 1)
{
    Console.WriteLine($"Введите {M} раз любое число(положительное или отрицательное): ");
    int N = more0(M);
    Console.WriteLine();
    Console.WriteLine($"Вы ввели {N} раз число больше 0");
}

else if (answer == 2)
{
    int X = more01(M);
    Console.WriteLine();
    Console.WriteLine($"С помощью генератора получили {X} раз число больше 0.");
}

else
{
    Console.WriteLine("Вы ввели отличную от 1 и 2 цифру");
}

int more0(int M)  // функция с ручным вводом.
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0)
        {
            count++;
        }
    }
    return count;
}

int more01(int M)  // функция с автоматическим вводом
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        int num = new Random().Next(-100, 101);
        Console.WriteLine($"Полученное число {i + 1} --> {num}");
        if (num > 0)
        {
            count++;
        }
    }
    return count;
}


