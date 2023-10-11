using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace CobaPAWUASNo2
{
    //Membuat public class
    public class Soalno2
    {
        public void soalno2()
        {
            {
                //membuat tampilan awal program
                Console.WriteLine("========================================\n");
                Console.WriteLine("          Program Kasir Kafe              ");
                Console.WriteLine("             Sixteen Cafe\n               ");
                Console.WriteLine("========================================\n");
                Console.WriteLine("Makanan\n");
                Console.WriteLine(" 1. Sosis Bakar          : Rp 5000");
                Console.WriteLine(" 2. Kentang Goreng       : Rp 10000");
                Console.WriteLine(" 3. Nasi Goreng          : Rp 15000");
                Console.WriteLine(" 4. Donat                : Rp 8000\n\n");

                Console.WriteLine("Minuman\n");
                Console.WriteLine(" 1. Susu                 : Rp 7000");
                Console.WriteLine(" 2. Kopi                 : Rp 7000");
                Console.WriteLine(" 3. Teh                  : Rp 5000");
                Console.WriteLine(" 4. Jus                  : Rp 10000\n\n");

                //memasukkan nama pembeli
                Console.WriteLine();
                Console.Write("Masukkan Nama Pembeli : ");
                string namapembeli = Console.ReadLine();

                //Looping menginput jumlah barang menggunakan kondisi do while 
                int jumlah;
                do
                {
                    Console.Write("Masukkan Jumlah Barang [0...100] : ");
                    jumlah = int.Parse(Console.ReadLine());

                } while (jumlah <= 0 || jumlah > 100);

                //Looping menggunakan kombinasi array
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;


                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //menginput nama barang
                        Console.Write("\nMasukkan Nama Barang Ke-" + (i + 1) + " [0....20 karakter] : ");
                        nama[i] = Console.ReadLine();
                    } while (nama[i].Length <= 0 || nama[i].Length >= 20);
                    do
                    {
                        //menginput harga barang
                        Console.Write("\nMasukkan Harga Barang Ke-" + (i + 1) + " [5000....1000000] : ");
                        harga[i] = int.Parse(Console.ReadLine());

                        //User harus menginput harga barang antara 5000 - 1000000
                    } while (harga[i] <= 4000 || harga[i] >= 1000000);
                }
                //Menampilkan list harga dan barang yang sudah dipilih
                Console.WriteLine();
                Console.WriteLine("=============================");
                Console.WriteLine("Nama Pembeli: " + namapembeli);
                Console.WriteLine("Daftar Barang Yang Dipilih");
                Console.WriteLine("=============================");

                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
                }
                foreach (int i in harga)
                {
                    total += i;
                }
                //menampilkan total harga
                Console.WriteLine("============================");
                Console.WriteLine("Total Harga :   " + total);
                

                do
                {
                    Console.Write("\nUang Yang Dibayarkan: ");
                    bayar = int.Parse(Console.ReadLine());

                    //Menampilkan uang kembalian
                    kembalian = bayar - total;

                    //Menampilkan jika uang yang dibayarkan kurang
                    if (bayar < total)
                    {
                        Console.WriteLine("=====================================");
                        Console.WriteLine("Maaf Uang Yang Anda Bayarkan Kurang !");
                        Console.WriteLine("=====================================");
                    }
                    //Menampilkan jika uang yang dibayarkan lebih atau menampilkan uang kembalian
                    else
                    {
                        Console.WriteLine("\nUang Kembalian Anda : Rp " + kembalian);
                    }

                } while (bayar < total);
                //Menampilkan ucapan terima kasih
                Console.WriteLine("=====================================");
                Console.WriteLine(" Nama Kasir : Naufal           ");
                Console.WriteLine(" Terima Kasih Telah Berbelanja ");
                Console.WriteLine(" Tanggal : "+ DateTime.Now      );
                Console.WriteLine("=====================================");
                Console.WriteLine();
                Console.WriteLine("Nota Telah Dicetak");

                //membuat bagian nota yang akan dicetak
                using (StreamWriter sw = new StreamWriter(@"D:\Nota Kasir Kafe\Nota.txt"))
                {
                    //membuat tampilan nota
                    sw.WriteLine("========== Nota Pembayaran ==========");
                    sw.WriteLine(" Nama Kasir : Naufal           ");
                    sw.WriteLine(" Nama Pembeli : " + namapembeli );
                    sw.WriteLine(" Tanggal : " + DateTime.Now     );
                    sw.WriteLine("=====================================\n");
                    sw.WriteLine("=============================");
                    sw.WriteLine("Daftar Barang Yang Dipilih");
                    sw.WriteLine("=============================");

                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
                    }
                    foreach (int i in harga)
                    
                    sw.WriteLine("=============================");
                    sw.WriteLine("Total Harga :   " + total);
                    sw.WriteLine("\nUang Yang Dibayarkan: " + bayar);
                    sw.WriteLine();
                    sw.WriteLine("\nUang Kembalian Anda : Rp " + kembalian);
                    sw.WriteLine("=================================");
                    sw.WriteLine(" Terima Kasih Telah Berbelanja ");
                    sw.WriteLine("=================================");

                }
                Console.ReadLine();
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                //memanggil kelas
                Soalno2 soall = new Soalno2();
                soall.soalno2();
            }
        }
    }
}