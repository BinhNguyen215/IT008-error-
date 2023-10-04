using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static int TimSoLonNhat(int[] mangSoNguyen)
    {
        if (mangSoNguyen.Length == 0)
        {
            throw new ArgumentException("Dãy số nguyên không được rỗng.");
        }
        return mangSoNguyen.Max();
    }

    static double TimSoLonNhat(double[] mangSoThuc)
    {
        if (mangSoThuc.Length == 0)
        {
            throw new ArgumentException("Dãy số thực không được rỗng.");
        }
        return mangSoThuc.Max();
    }

    static string TimChuoiDaiNhat(string[] mangChuoi)
    {
        if (mangChuoi.Length == 0)
        {
            throw new ArgumentException("Dãy chuỗi không được rỗng.");
        }
        return mangChuoi.OrderByDescending(chuoi => chuoi.Length).First();
    }

    static int TimSoNhoNhat(int[] mangSoNguyen)
    {
        if (mangSoNguyen.Length == 0)
        {
            throw new ArgumentException("Dãy số nguyên không được rỗng.");
        }
        return mangSoNguyen.Min();
    }

    static double TimSoNhoNhat(double[] mangSoThuc)
    {
        if (mangSoThuc.Length == 0)
        {
            throw new ArgumentException("Dãy số thực không được rỗng.");
        }
        return mangSoThuc.Min();
    }

    static string TimChuoiNganNhat(string[] mangChuoi)
    {
        if (mangChuoi.Length == 0)
        {
            throw new ArgumentException("Dãy chuỗi không được rỗng.");
        }
        return mangChuoi.OrderBy(chuoi => chuoi.Length).First();
    }

    static void Main()
    {
        int[] mangSoNguyen = { 4, 9, 2, 7, 1 };
        double[] mangSoThuc = { 3.14, 2.71, 1.618, 0.577 };
        string[] mangChuoi = { "apple", "banana", "cherry", "date" };

        Console.WriteLine("Số lớn nhất trong mảng số nguyên: " + TimSoLonNhat(mangSoNguyen));
        Console.WriteLine("Số lớn nhất trong mảng số thực: " + TimSoLonNhat(mangSoThuc));
        Console.WriteLine("Chuỗi dài nhất trong mảng chuỗi: " + TimChuoiDaiNhat(mangChuoi));

        Console.WriteLine("Số nhỏ nhất trong mảng số nguyên: " + TimSoNhoNhat(mangSoNguyen));
        Console.WriteLine("Số nhỏ nhất trong mảng số thực: " + TimSoNhoNhat(mangSoThuc));
        Console.WriteLine("Chuỗi ngắn nhất trong mảng chuỗi: " + TimChuoiNganNhat(mangChuoi));
    }
}

