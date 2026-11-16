using System;

namespace SiMewah.Models
{
    public class DataEvaluasiBurung
    {
        public Guid IdBurung { get; set; }
        public int TotalSiklus { get; set; }
        public int TotalTelur { get; set; }
        public int TotalMenetas { get; set; }
        public int JumlahVitaminBulanIni { get; set; }
        public int JumlahPakanBulanIni { get; set; }

        public double HitungPersentaseMenetas()
        {
            if (TotalTelur == 0) return 0.0;
            return ((double)TotalMenetas / TotalTelur) * 100.0;
        }
    }

    public class Rekomendasi
    {
        public Guid IdRekomendasi { get; set; }
        public DateTime TanggalRekomendasi { get; set; }
        public string HasilRekomendasi { get; set; }
        public string Keterangan { get; set; }
        public Guid IdBurung { get; set; }
        public Guid? IdPerawatan { get; set; }
        public Guid? IdPerkawinan { get; set; }
        public Guid? IdTelur { get; set; }
        public Guid? IdPenetasan { get; set; }

        public Rekomendasi()
        {
            IdRekomendasi = Guid.NewGuid();
            TanggalRekomendasi = DateTime.Now;
        }
    }
}