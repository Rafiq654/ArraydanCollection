using System;
using System.Threading.Channels;

namespace LatihanArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat array sekaligus inisialisasi nilai
            string[] arrNama = { "erick", "wely", "sony", "joni" };

            // menampilkan elemen array index ke 2
            Console.WriteLine(arrNama[2].ToString() + "\n");

            // menampilkan semua elemen array 
            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine(arrNama[i]);
            }
            Console.WriteLine(); // Cetak baris kosong

            // menampilkan semua elemn array menggunakan foreach
            foreach (string nama in arrNama)
            {
                Console.WriteLine(nama);
            }
            Console.WriteLine(); // cetak baris kosong

            // membuat array
            int[] arrBil = new int[3];

            // inisialisasi nilai array 
            arrBil[0] = 12;
            arrBil[1] = 14;
            arrBil[2] = 24;

            // menampilkan semua elemen array menggunakan foreach
            foreach (int bil in arrBil)
            {
                Console.WriteLine(bil.ToString());
            }

            Console.ReadKey();
        }
    }
}
