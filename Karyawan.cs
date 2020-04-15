using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2850
{
    class Karyawan
    {
        public string NIK, Nama;
        public int GajiBulanan;

        public Karyawan(string nik, string nama, int gaji)
        {
            NIK = nik;
            Nama = nama;
            GajiBulanan = gaji;

            if (gaji < 0)
            {
                gaji = 0;
            }
        }
    }
}