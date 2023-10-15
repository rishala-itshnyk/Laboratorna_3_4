using System;

class Program
{
    static void Main()
    {
        double x; // вхідний аргумент
        double y; // вхідний параметр
        double R; // вхідний параметр
        
        
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = double.Parse(Console.ReadLine());
        Console.Write("R = ");
        R = double.Parse(Console.ReadLine());

        // розгалуження в повній формі
        if (((x + R) * (x + R) + (y - R) * (y - R) <= R * R) ||
            ((y >= -R) && (y <= 0) && (x >= 0) && (x <= 2 * R)))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        Console.ReadLine();
    }
}