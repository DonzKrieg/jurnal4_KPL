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
        }
    }
}
