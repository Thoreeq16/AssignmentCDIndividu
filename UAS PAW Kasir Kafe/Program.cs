using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace UAS_PAW_KasirKafe
{
    /// <summary>
    /// kelas untuk mengimplementasikan program kasir kafe
    /// </summary>
    public class Kasir
    {
        /// <summary>
        /// method untuk menghandle function dari program kasir kafe
        /// </summary>
        public void KasirKafe()
        {
            {

                //Menampilkan menu utama pada program
                ///<example>
                ///ketika program dijalankan akan menampilkan nama dari program sampai ke menu minuman
                ///</example>
                Console.WriteLine("========================================");
                Console.WriteLine("           Program Kasir Kafe           ");
                Console.WriteLine("           Artemis Coffeeshop           ");
                Console.WriteLine("========================================");
                Console.Write("\n");
                Console.WriteLine("  Silahkan memilih pesanan pada menu  ");
                Console.Write("\n");
                //Menampilkan menu makanan
                Console.WriteLine("========== M A K A N A N A N =========");
                Console.Write("\n");
                Console.WriteLine(" Frecnh Fries              : Rp 10.000");
                Console.WriteLine(" Donat Kentang             : Rp 8.000");
                Console.WriteLine(" Pisang Nugget             : Rp 13.000");
                Console.Write("\n");
                //Menampilkan menu Minuman
                ///<code>
                ///pada kode dibaris 45-50 akan menampilkan menu minuman yang tersedia pada program kasir kafe
                ///</code>
                Console.WriteLine("============ M I N U M A N ===========");
                Console.WriteLine(" Americano                 : Rp 15.000");
                Console.WriteLine(" Vietnam Drip              : Rp 15.000");
                Console.WriteLine(" Espresso                  : Rp 17.000");
                Console.WriteLine(" Macchiato                 : Rp 18.000");
                Console.WriteLine(" Caramel Macchiato         : Rp 20.000");


                int jumlah;
                //Looping dengan menginput jumlah barang menggunakan kondisi do while
                do
                {
                    Console.Write("\nMasukan jumlah barang: ");
                    jumlah = int.Parse(Console.ReadLine());

                } while (jumlah <= 0 || jumlah > 100);

                //Mendefinisikan variable data
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;


                //Menampilkan masukan nama pelanggan
                ///<example>
                ///ketika program dijalankan maka akan muncul pesan "Masukkan nama pelanggan :", ketika nama pelanggan sudah diinput maka data tersebut akan tersimpan di variabel string namapl
                ///</example>
                Console.WriteLine("===========================");
                Console.Write("Masukkan nama pelanggan :");
                //deklarasi variable data string
                string namapl = Console.ReadLine();

                //Looping menggunakan kombinasi array
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //Menampilkan input nama barang
                        Console.WriteLine("===========================");
                        Console.Write("Masukan nama barang ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                    } //User harus menginput nama barang diatas 0 karakter sampai dengan 20 karakter
                    while (nama[i].Length <= 0 || nama[i].Length >= 20);

                    do
                    {
                        //Menampilkan input harga
                        Console.WriteLine("===========================");
                        Console.Write("Masukan harga barang ke-" + (i + 1) + ": ");
                        harga[i] = int.Parse(Console.ReadLine());
                        //User harus menginput harga barang minimal 5000 sampai 1000000
                    }
                    while (harga[i] <= 5000 || harga[i] >= 1000000);

                }
                //Meanmpilkan barang dan harga yang sudah dipilih
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("===========================");
                Console.WriteLine("Daftar Menu Yang Dipilih");
                Console.WriteLine("===========================");
                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);

                }
                foreach (int i in harga)
                {
                    total += i;
                }

                //Menampilkan total harga
                ///<example>
                ///jika kode dijalankan maka akan menampilkan total harga yang harus dibayar oleh customer
                ///</example>
                ///<code>
                ///pada kode "Console.WriteLine("Total harga : Rp" + total);" akan muncul total harga yang harus dibayar oleh customer
                ///</code>
                Console.WriteLine("===========================");
                Console.WriteLine("Total harga : Rp" + total);

                do
                {
                    ///<code>
                    ///pada kode "Console.Write("Masukan tunai : Rp"), bayar = int.Parse(Console.ReadLine())" user harus menginput berapa uang tunai yang dibayarkan oleh customer
                    ///</code>
                    Console.Write("Masukan tunai : Rp");
                    bayar = int.Parse(Console.ReadLine());

                    //Menampilkan uang kembalian yang dari uang yang dibayarkan dikurangi uang total
                    ///<code>
                    ///pada kode "kembalian = bayar - total;" program akan menampilkan uang kembalian
                    ///</code>
                    kembalian = bayar - total;

                    //Kondisi jika input uang yang dibayar kurang
                    ///<code>
                    ///pada kode "if (bayar < total)" program akan menampilkan tulisan (Maaf uang anda kurang) ini terjadi apabila uang yang dibayarkan oleh customer kurang dari total harga
                    ///</code>
                    if (bayar < total)
                    {

                        Console.WriteLine("Maaf uang anda kurang");

                    }
                    //Kondisi dimana input uang yang dibayar lebih
                    else //menampilkan uang kembalian
                    {
                        Console.WriteLine("Uang kembalian Anda : Rp" + kembalian);
                    }

                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama pelanggan : {0}", namapl.ToString());
                Console.Write("\n");
                //Menampilkan tanggal dan waktu Transaksi
                Console.WriteLine("Tanggal transaksi:" + DateTime.Today.ToString("yyy-MM-dd"));
                Console.WriteLine("Jam transaksi:" + DateTime.Now.ToString("HH-mm-ss"));
                Console.WriteLine("====================================");
                Console.WriteLine("Nama kasir : Mbappe ");
                Console.WriteLine("Thank You!");
                Console.WriteLine("====================================");

                //Mencetak nota dengan menggunakan streamwritter
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Thoriq Hidayatullah\source\repos\UAS PAW\Nota\nota.txt"))//Lokasi tempat file nota dicetak
                {
                    sw.WriteLine("========================================================");
                    sw.WriteLine("====================NOTA PEMBAYARAN=====================");
                    sw.WriteLine("========================================================");
                    sw.WriteLine("                Nama barang yang dibeli                 ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + " " + harga[i]);
                    }
                    sw.WriteLine("========================================================");
                    sw.WriteLine("Total harga   : Rp" + total);
                    sw.WriteLine("Tunai         : Rp" + bayar);
                    sw.WriteLine("Kembalian     : Rp" + kembalian);
                    sw.WriteLine("\n");
                    //Menampilkan nama pelanggan
                    sw.WriteLine("Nama Pelanggan {0}", namapl.ToString());
                    //Menampilkan tanggal dan waktu transaksi
                    sw.WriteLine("Tanggal transaksi :" + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam transaksi :" + DateTime.Now.ToString("HH-mm-ss"));
                    sw.WriteLine("========================================================");
                    sw.WriteLine("Nama Kasir :  Mbappe ");
                    sw.WriteLine("      Thank You!     ");
                    sw.WriteLine("========================================================");
                    Console.Write("\n");
                    Console.WriteLine("Nota telah di print");

                }
                Console.WriteLine();
                Console.Write("Tekan 'ENTER' untuk keluar...");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            //Memanggil kelas KasirKafe
            Kasir KasirK = new Kasir();
            KasirK.KasirKafe();

        }
    }
}