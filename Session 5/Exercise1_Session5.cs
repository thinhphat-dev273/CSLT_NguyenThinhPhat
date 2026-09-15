using System;

class Exercises
{
    //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
    static void Bai4()
    {
        double a, b, c;
        Console.Write("Nhập độ dài cạnh A: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Nhập độ dài cạnh B: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Nhập độ dài cạnh C: ");
        c = double.Parse(Console.ReadLine());

        if(a == b || a == c || b == c)
        {
            Console.WriteLine("Đây là tam giác cân");
        } 
        else if (a==b && a == c)
        {
            Console.WriteLine("Đây là tam giác đều");
        } 
        else
        {
            Console.WriteLine("Đây là tam giác thường");
        }
    }
    //Write a program to read 10 numbers and find their average and sum.
        static void Bai5()
    {
        double sum = 0;

        Console.WriteLine("Hãy nhập 10 số:");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Number {i}: ");
            
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                sum += num;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--; 
            }
        }
            double average = sum / 10;
            Console.WriteLine($"Tổng 10 số = {sum}");
            Console.WriteLine($"Trung bình cộng 10 số = {average}");

    }
    //Write a program to display the multiplication table of a given integer.
    static void Bai6()
    {
        int a;
        Console.Write("Nhập vào một số nguyên: ");
        a = int.Parse(Console.ReadLine());
        int product = 0;

        for(int i = 1; i <=10; i++)
        {
            product = a * i;
            Console.WriteLine($"{a} * {i} = {product} ");
        }
    }
    static void Bai7()
    {
        int n = 4; 
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    static void Bai8()
    {
        int n;
        Console.Write("Nhập n: ");
        n = int.Parse(Console.ReadLine());
        double sum = 0;
        for(int i = 1; i <=n; i++)
        {
            sum += 1.0/i;
        }
        Console.WriteLine($"Tổng 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/{n} terms ={sum}");
    }
    static void Bai9()
    {
        int a,b;
        Console.Write("Nhập khoảng cách a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Nhập khoảng cách b: ");
        b = int.Parse(Console.ReadLine());

        for(int n = a; n <= b; n++)
        {
            int tong = 0;
            for(int i =1; i < n; i++)
            {
                if (n% i == 0)
                {
                    tong += i;
                }
            }
            if(tong == n)
            {
                Console.WriteLine($"{n} là số hoàn hảo trong khoảng {a} và {b} ");
            }  else
            {
                Console.WriteLine($"Không có số nào là số hhảo giữa {a} và {b}");
            }
        }
    }
    static void Bai10()
    {
        int n;
        Console.Write("Nhập vào một số lớn hơn 1: ");
        while (true)
        {
            if(int.TryParse(Console.ReadLine(), out n) && n > 1)
            {
                break;
            } Console.WriteLine("Vui lòng nhập số lớn hơn 1");
        }
        if (n < 2) 
        {
        Console.WriteLine($"{n} không phải là số nguyên tố.");
        return; 
        }
        for (int i = 2; i * i <= n; i++)
        {
        if (n % i == 0)
            {
            Console.WriteLine($"{n} không phải là số nguyên tố.");
            break;
            }
             Console.WriteLine($"{n} là số nguyên tố.");
        }
    }  
    static void Main()
    {
        Bai10();
    }
}   