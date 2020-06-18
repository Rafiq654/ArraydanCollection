using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace LatihanList2
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            // membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";

            // membuat objek Dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            // membuat objek List
            List<Mahasiswa> list = new List<Mahasiswa>();

            // menambah elemen List
            // tidak ada proses boxing
            list.Add(mhs1);
            list.Add(mhs2);

            // coba tambahkan objek dosen ke list, apa yang terjadi?
            //list.Add(dosen);

            // mengakses element List
            // tidak ada proses unboxing
            Mahasiswa mhs = list[1];
            Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);


        }
    }
}
