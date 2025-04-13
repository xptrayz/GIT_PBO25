using System;

namespace SistemKaryawan
{
    
    // CLASS INDUK
    // =============================
    class Karyawan
    {
        private string nama;
        private string id;
        private double gajiPokok;

        // Getter dan Setter
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public double GajiPokok
        {
            get { return gajiPokok; }
            set { gajiPokok = value; }
        }

        // Virtual Method untuk dihitung ulang di subclass
        public virtual double HitungGaji()
        {
            return GajiPokok;
        }
    }

    
    // CLASS TURUNAN: Karyawan Tetap
    // =============================
    class KaryawanTetap : Karyawan
    {
        private const double bonusTetap = 500000;

        public override double HitungGaji()
        {
            return GajiPokok + bonusTetap;
        }
    }

    
    // CLASS TURUNAN: Karyawan Kontrak
    // =============================
    class KaryawanKontrak : Karyawan
    {
        private const double potonganKontrak = 200000;

        public override double HitungGaji()
        {
            return GajiPokok - potonganKontrak;
        }
    }

    
    // CLASS TURUNAN: Karyawan Magang
    // =============================
    class KaryawanMagang : Karyawan
    {
        public override double HitungGaji()
        {
            return GajiPokok;
        }
    }

    
    // CLASS UTAMA: Program
    // =============================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEM MANAJEMEN KARYAWAN ===");
            Console.Write("Masukkan jenis karyawan (tetap/kontrak/magang): ");
            string jenis = Console.ReadLine().ToLower();

            Console.Write("Masukkan Nama: ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan ID: ");
            string id = Console.ReadLine();
            Console.Write("Masukkan Gaji Pokok: ");
            double gaji = Convert.ToDouble(Console.ReadLine());

            Karyawan karyawan;

            if (jenis == "tetap")
            {
                karyawan = new KaryawanTetap();
            }
            else if (jenis == "kontrak")
            {
                karyawan = new KaryawanKontrak();
            }
            else if (jenis == "magang")
            {
                karyawan = new KaryawanMagang();
            }
            else
            {
                Console.WriteLine("Jenis karyawan tidak valid.");
                return;
            }

            // Set nilai properti
            karyawan.Nama = nama;
            karyawan.ID = id;
            karyawan.GajiPokok = gaji;

            // Tampilkan hasil
            Console.WriteLine("\n=== HASIL PENGGAJIAN ===");
            Console.WriteLine("Nama     : " + karyawan.Nama);
            Console.WriteLine("ID       : " + karyawan.ID);
            Console.WriteLine("Gaji Akhir: Rp" + karyawan.HitungGaji().ToString("N0"));
        }
    }
}