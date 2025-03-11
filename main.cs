namespace modul4_103022330150
{
    internal class main
    {
        static void Main(string[] args)
        {
            KodeProduk kodeProduk = new KodeProduk();

            Console.WriteLine("Masukkan nama produk:");
            string produk = Console.ReadLine();
            Console.WriteLine("Kode Produk " + produk + "-> " + kodeProduk.getKodeProduk(produk));

            FanLaptop fan = new FanLaptop();
            while (true) {
                Console.WriteLine("\n--- Pilih mode kipas:");
                Console.WriteLine("1. Mode Up");
                Console.WriteLine("2. Mode Down");
                Console.WriteLine("3. Turbo Shorcut");
                Console.WriteLine("4. Simpan dan keluar");
                Console.Write("Pilihan: ");

                string pilihan = Console.ReadLine();

                if (pilihan == "1")
                {
                    fan.modeUp();
                }
                else if (pilihan == "2")
                {
                    fan.modeDown();
                }
                else if(pilihan == "3")
                {
                    fan.turboShort();
                }
                else if (pilihan == "4")
                {
                    Console.WriteLine("Mode berhasil diubah!");
                    break;
                }
                else
                {
                    Console.WriteLine("Masukkan tidak valid!");
                }

            }
        }
    }
}
