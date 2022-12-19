// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84 - пример
// A (7,-5, 0); B (1,-1,9) -> 11.53 - пример

var x1 = ReadInt("Координата х1: ");
var y1 = ReadInt("Координата y1: ");
var z1 = ReadInt("Координата z1: ");

var x2 = ReadInt("Координата х2: ");
var y2 = ReadInt("Координата y2:");
var z2 = ReadInt("Координата z2: ");

var A = x2 - x1;
var B = y2 - y1;
var C = z1 - z2;

double length = Math.Sqrt(A*A + B*B + C*C);
Console.WriteLine($"Ответ: {length}");


// Функции задачи № 2

    // Вызов: строки № 6 - 12
    int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }