using System;
using System.Collections.Generic;

namespace LatihanList
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek list untuk menampung tipe data integer
            List<int> listNilai = new List<int>();

            // menambah element list 
            // tidak ada proses boxing
            listNilai.Add(70);
            listNilai.Add(100);
            listNilai.Add(85);

            // mengakses element list
            // tidak ada proses unboxing
            int nilaiElement1 = listNilai[1];

            Console.WriteLine(nilaiElement1);
            Console.WriteLine();

            foreach (int nilai in listNilai)
            {
                Console.WriteLine(nilai);
            }

            Console.ReadKey();
        }
    }
}
