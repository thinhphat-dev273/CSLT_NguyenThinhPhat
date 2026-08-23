using System;

class Exercises
{
    static void Main()
    {
        Console.WriteLine("1. Convert degrees Celsius to Kelvin and Fahrenheit");
        Console.Write("Nhap do C (celsius): ");
        double celsius = double.Parse(Console.ReadLine());

        double kelvin = celsius + 273;
        double fahrenheit = (celsius * 18.0 / 10.0) + 32;

        Console.WriteLine($"kelvin = {kelvin}");
        Console.WriteLine($"fahrenheit = {fahrenheit}");
        Console.WriteLine();

        Console.WriteLine("2. Calculate the surface and volume of a sphere, given its radius");
        Console.Write("Nhap ban kinh (radius): ");
        double radius = double.Parse(Console.ReadLine());

        double surface = 4 * Math.PI * Math.Pow(radius, 2);
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

        Console.WriteLine($"Surface: {surface:F2}");
        Console.WriteLine($"Volume: {volume:F1}");
        Console.WriteLine();

        Console.WriteLine("3. Calculate the result of adding, subtracting, multiplying and dividing two numbers");
        Console.Write("Nhap so thu nhat: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} x {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}");
        Console.WriteLine($"{a} mod {b} = {a % b}");
    }
}
