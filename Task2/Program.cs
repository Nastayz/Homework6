/*Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double GetNumber (string message) {
    double result = 0;

    while (true) {
        Console.WriteLine(message);
        if ((double.TryParse(Console.ReadLine(), out result)) && (result>0)) {
            break;
        }
        else {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}

double k1 = GetNumber("Введите значение k1");
double b1 = GetNumber("Введите значение b1");
double k2 = GetNumber("Введите значение k2");
double b2 = GetNumber("Введите значение b2");

double x = 0;
double y = 0;

if (k1 != k2) {
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} пересекаются в точке ({x}, {y})");
}
else {
    Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} параллельны");
}

