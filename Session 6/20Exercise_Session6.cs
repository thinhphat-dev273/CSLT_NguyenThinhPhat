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
    Array.Reverse(charArray); 
    return new string(charArray);
    }
    //Bài 6
    public static bool SoNguyenTo(int n1)
    {
        if(n1<1) return false;
        if(n1==1) return true;
        for(int i =2; i< n1/2; i++)
        {
            if(n1 % i == 0) return false;
        }
        return true;
    }
    //Bài 7
    public static void Fibonacci(int n2)
    {
        if(n2 < 0)
        {
            Console.WriteLine("Số truyền vào phải là số nguyên dương");
            return;
        } 
        if(n2 == 0)
        {
            Console.WriteLine("0"); 
            return;
        }
        if(n2 == 1)
        {
            Console.WriteLine("1"); 
            return;
        }
        long a = 0;
        long b = 1;
        long fibo = 0;
        Console.Write("0, 1, ");
        for(int i = 2; i < n2; i++)
        {
            fibo = a + b;
            a = b;
            b = fibo;
            Console.Write($"{fibo} , ");
        }
    }
    //Bài 8
    public static int DemNguyenAm(string s)
    {
        if(string.IsNullOrEmpty(s)) return 0;
        char [] mangKyTu = s.ToCharArray();
        int dem = 0;
        foreach(char vowel in mangKyTu)
        {
            if(vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u' ||
               vowel == 'A' || vowel == 'E' || vowel == 'I' || vowel == 'O' || vowel == 'U')
            {
                dem++;
            }
        }
        return dem;
    }
    public static double TinhLuyThua(double x, int y)
    {
        if(y==0) return 1;
        double result = 1;
        for(int i = 1; i <= y; i++)
        {
            result *= x;
        }
        return result;
    }
    public static void Main(String[] args)
    {
        // Console.WriteLine("\n---Bài 1---");
        // Console.Write("Nhập vào số nguyên a: ");
        // int a = int.Parse(Console.ReadLine() ?? "0");
        // Console.Write("Nhập vào số nguyên b: ");
        // int b = int.Parse(Console.ReadLine() ?? "0");
        // int tong = TinhTong(a,b);
        // Console.WriteLine($"Tổng của {a} và {b} là: {tong}");

        // Console.WriteLine("\n---Bài 2---");
        // Console.Write("Nhập vào số nguyên n: ");
        // int n = int.Parse(Console.ReadLine() ?? "0");
        // if (ChanLe(n))
        // {
        //     Console.WriteLine($"{n} là số chẵn");
        // }
        // else
        // {
        //     Console.WriteLine($"{n} là số lẻ");
        // }

        // Console.WriteLine("\n---Bài 3---");
        // Console.Write("Nhập số nguyên a: ");
        // int a1 = int.Parse(Console.ReadLine() ?? "0");
        // Console.Write("Nhập số nguyên b: ");
        // int b1 = int.Parse(Console.ReadLine() ?? "0");
        // Console.Write("Nhập số nguyên c: ");
        // int c1 = int.Parse(Console.ReadLine() ?? "0");
        // int max = TimSoLonNhat(a1, b1, c1);
        // Console.WriteLine($"Số lớn nhất trong 3 số {a1}, {b1}, {c1} là: {max}");

        // Console.WriteLine("\n---Bài 4---");
        // Console.Write("Nhập một số nguyên dương n: ");
        // int n = int.Parse(Console.ReadLine() ?? "0");
        // long tinhGiaiThua = GiaiThua(n);
        // Console.WriteLine($"Giai thừa của {n} là: {tinhGiaiThua}");

        // Console.WriteLine("\n---Bài 5---");
        // Console.Write("Nhập một chuỗi: ");
        // string input = Console.ReadLine() ?? "0";
        // Console.WriteLine($"Chuỗi sau khi đảo ngược là:{DaoNguocChuoi(input)} ");

        // Console.WriteLine("\n---Bài 6---");
        // Console.Write("Nhập một số nguyên dương n: ");  
        // int n1 = int.Parse(Console.ReadLine() ?? "0");
        // if (SoNguyenTo(n1))
        // {
        //     Console.WriteLine($"{n1} là số nguyên tố");
        // }
        // else
        // {
        //     Console.WriteLine($"{n1} không phải là số nguyên tố");
        // }

        // Console.WriteLine("\n---Bài 7---");
        // Console.Write("Nhập một số nguyên dương n: ");
        // int n2 = int.Parse(Console.ReadLine() ?? "0");
        // Console.Write($"{n2} số fibonacci đầu tiên là: ");
        // Fibonacci(n2);

        // Console.WriteLine("\n---Bài 8---");
        // Console.Write("Nhập một chuỗi vào để kiểm tra: ");
        // string s = Console.ReadLine() ?? "0";
        // int demNguyenAm = DemNguyenAm(s);
        // Console.WriteLine($"Số nguyên âm trong chuỗi \"{s}\" là: {demNguyenAm}");

        Console.WriteLine("\n---Bài 9---");
        Console.Write("Nhập vào cơ số x: ");
        double x = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập vào số mũ y: ");
        int y = int.Parse(Console.ReadLine() ?? "0");
        double luyThua = TinhLuyThua(x,y);
        Console.WriteLine($"{x} ^ {y} = {luyThua}");
    }
}
