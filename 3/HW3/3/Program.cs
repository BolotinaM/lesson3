// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 - пример
// 5 -> 1, 8, 27, 64, 125 - пример

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    for (int j = 1; j < 6; j++)
    {
        Console.Write($"{i*i*i} ");
        i = i+1;
    }
    Console.WriteLine("");
}

// Функции задачи № 3
    // Вызов: строка № 5
    int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }