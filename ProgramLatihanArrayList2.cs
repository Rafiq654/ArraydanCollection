using System;
using System.Collections;

namespace LatihanArrayList2
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

            //membuat objek Dosen
            Dosen dosen1 = new Dosen();
            dosen1.Nik = "0043";
            dosen1.NamaDosen = "Jhono";

            Dosen dosen2 = new Dosen();
            dosen2.Nik = "0045";
            dosen2.NamaDosen = "Jhoni";

            // membuat objek ArrayList
            ArrayList list = new ArrayList();

            // menambah elemen ArrayList
            list.Add(mhs1); // boxing
            list.Add(mhs2);
            list.Add(dosen1);
            list.Add(dosen2);

            // mengakses elemen ArrayList
            Mahasiswa mhs = (Mahasiswa)list[1]; // unboxing
            Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);

            Dosen dosen = (Dosen)list[2]; // unboxing
            Console.WriteLine("{0}, {1}", dosen.Nik, dosen.NamaDosen);

            Console.ReadKey();
        }
    }
}
