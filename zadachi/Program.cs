
Zadacha41();
// Zadacha43();

void Zadacha41()
{
    // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    
    Console.WriteLine("Введите число(в разумных пределах): ");
    int m = Convert.ToInt32(Console.ReadLine());
    m = Math.Abs(m);
    Console.WriteLine($"Введите {m} чисел ");
    int[] array = new int[m];
    Console.WriteLine("Пользователь ввел " + NumbersCount(array) + " чисел, значение которых больше нуля!");
}
int NumbersCount(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

void Zadacha43()
{
    // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    
    Console.WriteLine("Уважаемый, задайте значение b1, k1, b2 и k2 для уравнений y = k1 * x + b1, y = k2 * x + b2");
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Точка пересечения двух прямых: {PointOfIntersection(b1, k1, b2, k2)}");
}
(double, double) PointOfIntersection(double b1, double k1, double b2, double k2)
{   
    double x = 0;
    double y = 0;
    if (k1 == k2)
    {
        Console.WriteLine("Прямые не пересекаются!");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * x + b1);  
    }
    return (Math.Round(x,2), Math.Round(y,2));
}