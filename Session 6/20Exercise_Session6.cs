using System;

class Exercises
{
    //Bài 1
    public static int TinhTong (int a, int b)
    {
        return a+b;
    }
    //Bài 2
    public static bool ChanLe(int n)
    {
        return n % 2 == 0;
    }
    //Bài 3
    public static int TimSoLonNhat(int a1, int b1, int c1)
    {
        return Math.Max(a1, Math.Max(b1, c1));
    }
    //Bài 4
    public static long GiaiThua(int n)
    {
        if (n < 0) throw new ArgumentException("Số truyền vào phải là số nguyên dương");
        long result = 1;
        for(int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    //bài 5
    public static string DaoNguocChuoi(string input)
    {
    if (string.IsNullOrEmpty(input)) return input;

    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray); // Đảo ngược trực tiếp trên mảng
    return new string(charArray);
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("---Bài 1---");
        Console.Write("Nhập vào số nguyên a: ");
        int a = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập vào số nguyên b: ");
        int b = int.Parse(Console.ReadLine() ?? "0");
        int tong = TinhTong(a,b);
        Console.WriteLine($"Tổng của {a} và {b} là: {tong}");

        Console.WriteLine("---Bài 2---");
        Console.Write("Nhập vào số nguyên n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        if (ChanLe(n))
        {
            Console.WriteLine($"{n} là số chẵn");
        }
        else
        {
            Console.WriteLine($"{n} là số lẻ");
        }
        Console.WriteLine("---Bài 3---");
        Console.Write("Nhập số nguyên a: ");
        int a1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập số nguyên b: ");
        int b1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập số nguyên c: ");
        int c1 = int.Parse(Console.ReadLine() ?? "0");
        int max = TimSoLonNhat(a1, b1, c1);
        Console.WriteLine($"Số lớn nhất trong 3 số {a1}, {b1}, {c1} là: {max}");

        Console.WriteLine("---Bài 4---");
        Console.Write("Nhập một số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        long tinhGiaiThua = GiaiThua(n);
        Console.WriteLine($"Giai thừa của {n} là: {tinhGiaiThua}");

        Console.WriteLine("---Bài 5---");
        Console.Write("Nhập một chuỗi: ");
        string input = Console.ReadLine() ?? "0";
        Console.WriteLine($"Chuỗi sau khi đảo ngược là:{DaoNguocChuoi(input)} ");
    }
}
