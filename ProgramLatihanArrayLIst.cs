using System;
using System.Collections;

namespace LatihanArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek ArrayList
            ArrayList arrBilangan = new ArrayList();

            // menambahkan elemen ArrayList
            arrBilangan.Add(12);
            arrBilangan.Add(14);
            arrBilangan.Add(17);

            int bil = (int)arrBilangan[2]; // unboxing
            Console.WriteLine(bil);
            Console.WriteLine(); // cetak baris kosong

            foreach (int bilangan in arrBilangan)
            {
                Console.WriteLine(bilangan);
            }

            Console.ReadKey();

        }
    }
}
