using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2850
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("191128501", "Aldi",  40000000);
            Karyawan karyawan2 = new Karyawan("191128502", "Prabowo", 20000000);

            Console.WriteLine("No.\tNIK/Nama\tGaji Bulanan");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1.\t{0} {1}\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. \t{0} {1}\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine();

            karyawan1.GajiBulanan = karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 10 / 100);
            karyawan2.GajiBulanan = karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 10 / 100);

            Console.WriteLine("Alhamdulillah... Gajinya naik 10%");
            Console.WriteLine();
            Console.WriteLine("No.\tNIK/Nama\tGaji Bulanan");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1.\t{0} {1}\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2.\t{0} {1}\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.ReadKey();
        }
    }
}