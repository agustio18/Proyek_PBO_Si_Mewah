using System;

namespace Kandang.Models
{
    public class Kandang
    {
        private string _jenisKandang = "";

        public Guid IdKandang { get; set; } = Guid.NewGuid();
        public string? Keterangan { get; set; }

        public string JenisKandang
        {
            get => _jenisKandang;
            set
            {
                if (value != "indukan" && value != "anakan" && value != "penjodohan")
                    throw new ArgumentException(
                        "Jenis kandang harus indukan, anakan, atau penjodohan.", nameof(JenisKandang));
                _jenisKandang = value;
            }
        }

        public Kandang()
        {
        }

        public Kandang(string jenisKandang)
        {
            JenisKandang = jenisKandang;
        }

        public Kandang(string jenisKandang, string? keterangan)
        {
            JenisKandang = jenisKandang;
            Keterangan = keterangan;
        }

        public Kandang(Guid idKandang, string jenisKandang, string? keterangan)
        {
            IdKandang = idKandang;
            JenisKandang = jenisKandang;
            Keterangan = keterangan;
        }
    }
}