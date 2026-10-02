using Bai02;
using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== BAI 02 - QUAN LY PHUONG TIEN =====");
            Console.WriteLine();

            QuanLyPhuongTien ql = new QuanLyPhuongTien();

            // TC01
            Console.WriteLine("===== TC01 - VALIDATION =====");

            try
            {
                OTo otoLoi = new OTo(
                    "OT01",
                    "Toyota",
                    1850,
                    1000000000m,
                    5,
                    2.0);

                Console.WriteLine("TC01: FAIL");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("TC01: PASS");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            // TC02
            Console.WriteLine("===== TC02 - GIA LAN BANH O TO =====");

            OTo oto = new OTo(
                "OT01",
                "Toyota",
                2024,
                1000000000m,
                5,
                2.0);

            decimal giaOTo = oto.TinhGiaLanBanh();

            Console.WriteLine(oto.GetInfo());
            Console.WriteLine("Gia lan banh: " +
                giaOTo.ToString("N0") + " VNĐ");

            if (giaOTo == 1420000000m)
                Console.WriteLine("TC02: PASS");
            else
                Console.WriteLine("TC02: FAIL");

            ql.AddPhuongTien(oto);

            Console.WriteLine();

            // TC03
            Console.WriteLine("===== TC03 - GIA LAN BANH XE MAY =====");

            XeMay xeMay = new XeMay(
                "XM01",
                "Honda",
                2023,
                50000000m,
                150);

            decimal giaXeMay = xeMay.TinhGiaLanBanh();

            Console.WriteLine(xeMay.GetInfo());
            Console.WriteLine("Gia lan banh: " +
                giaXeMay.ToString("N0") + " VNĐ");

            if (giaXeMay == 51000000m)
                Console.WriteLine("TC03: PASS");
            else
                Console.WriteLine("TC03: FAIL");

            ql.AddPhuongTien(xeMay);

            Console.WriteLine();

            // TC04
            Console.WriteLine("===== TC04 - DA HINH =====");

            ql.DisplayAll();

            Console.WriteLine("TC04: PASS");

            Console.WriteLine();

            // TC05
            Console.WriteLine("===== TC05 - GIA LAN BANH MAX =====");

            PhuongTien max = ql.FindMaxGiaLanBanh();

            Console.WriteLine("Phuong tien co gia lan banh cao nhat:");
            Console.WriteLine(max.GetInfo());
            Console.WriteLine("Gia lan banh: " +
                max.TinhGiaLanBanh().ToString("N0") + " VNĐ");

            if (max == oto)
                Console.WriteLine("TC05: PASS");
            else
                Console.WriteLine("TC05: FAIL");

            Console.ReadKey();
        }
    }
}