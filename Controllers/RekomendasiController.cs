using System;
using System.Collections.Generic;
using SiMewah.Models;
using SiMewah.Repositories;

namespace SiMewah.Controllers
{
    public class RekomendasiController
    {
        private readonly RekomendasiRepository _repository;

        public RekomendasiController()
        {
            _repository = new RekomendasiRepository();
        }

        public List<KeyValuePair<Guid, string>> GetDaftarBetina()
        {
            return _repository.GetDaftarBurungBetina();
        }

        public List<Rekomendasi> GetRiwayatRekomendasi(Guid idBurung)
        {
            return _repository.GetByBurung(idBurung);
        }

        public Rekomendasi AnalisisKelayakan(Guid idBurungBetina)
        {
            DataEvaluasiBurung eval = _repository.GetDataEvaluasi(idBurungBetina);
            var rek = new Rekomendasi { IdBurung = idBurungBetina };

            // Rule 1: Minimal 3 kali siklus penetasan
            if (eval.TotalSiklus < 3)
            {
                rek.HasilRekomendasi = "Lakukan Perkawinan Lagi";
                rek.Keterangan = $"Data siklus baru {eval.TotalSiklus} kali. Dibutuhkan minimal 3 siklus penetasan untuk menilai kualitas indukan.";
            }
            else
            {
                double persen = eval.HitungPersentaseMenetas();

                // Rule 2: Daya tetas rendah (<= 30%) TAPI vitamin kurang
                if (persen <= 30.0 && eval.JumlahVitaminBulanIni < 2)
                {
                    rek.HasilRekomendasi = "Tingkatkan Nutrisi";
                    rek.Keterangan = $"Daya tetas rendah ({persen:F1}%), namun vitamin kurang ({eval.JumlahVitaminBulanIni}x/bulan). Perbaiki pemberian vitamin dahulu sebelum mengganti indukan.";
                }
                // Rule 3: Daya tetas rendah (<= 30%) PADAHAL vitamin rutin
                else if (persen <= 30.0 && eval.JumlahVitaminBulanIni >= 2)
                {
                    rek.HasilRekomendasi = "Pemeriksaan Medis";
                    rek.Keterangan = $"Daya tetas sangat rendah ({persen:F1}%) meski vitamin rutin. Perlu pemeriksaan medis fertilitas atau disarankan untuk dijual.";
                }
                // Rule 4: Daya tetas sedang (31% - 60%) dan pakan/vitamin kurang
                else if (persen <= 60.0 && (eval.JumlahPakanBulanIni < 15 || eval.JumlahVitaminBulanIni < 2))
                {
                    rek.HasilRekomendasi = "Tingkatkan Nutrisi";
                    rek.Keterangan = $"Daya tetas sedang ({persen:F1}%), tetapi perawatan pakan/vitamin belum optimal. Tingkatkan nutrisi lagi untuk hasil maksimal.";
                }
                // Rule 5: Daya tetas sedang (31% - 60%) dan perawatan baik
                else if (persen <= 60.0)
                {
                    rek.HasilRekomendasi = "Siap Kawin";
                    rek.Keterangan = $"Performa penetasan stabil ({persen:F1}%) dengan perawatan baik. Layak dilanjutkan untuk siklus kawin berikutnya.";
                }
                // Rule 6: Daya tetas unggul (> 60%)
                else
                {
                    rek.HasilRekomendasi = "Siap Kawin";
                    rek.Keterangan = $"Indukan unggulan! Keberhasilan menetas mencapai {persen:F1}%. Sangat layak dipertahankan sebagai indukan utama.";
                }
            }

            _repository.Tambah(rek);
            return rek;
        }
    }
}