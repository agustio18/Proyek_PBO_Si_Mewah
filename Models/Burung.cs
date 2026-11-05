using System;

namespace Proyek_PBO___Si_Mewah.Models
{
    public class Burung
    {
        private string _jenisKelamin = "";
        private string _status = "aktif";
        private DateTime _tanggalLahir;

        public Guid IdBurung { get; set; } = Guid.NewGuid();
        public string KodeBurung { get; set; } = "";
        public Guid IdKandang { get; set; }

        public string JenisKelamin
        {
            get => _jenisKelamin;
            set
            {
                if (value != "jantan" && value != "betina")
                    throw new ArgumentException(
                        "Jenis kelamin harus jantan atau betina.", nameof(JenisKelamin));
                _jenisKelamin = value;
            }
        }

        public DateTime TanggalLahir
        {
            get => _tanggalLahir;
            set
            {
                if (value > DateTime.Today)
                    throw new ArgumentException(
                        "Tanggal lahir tidak boleh melebihi hari ini.", nameof(TanggalLahir));
                _tanggalLahir = value;
            }
        }

        public string Status
        {
            get => _status;
            set
            {
                if (value != "aktif" && value != "terjual" && value != "mati")
                    throw new ArgumentException(
                        "Status harus aktif, terjual, atau mati.", nameof(Status));
                _status = value;
            }
        }

        public Burung()
        {
        }

        public Burung(string kodeBurung, string jenisKelamin, DateTime tanggalLahir, Guid idKandang)
        {
            KodeBurung = kodeBurung;
            JenisKelamin = jenisKelamin;
            TanggalLahir = tanggalLahir;
            IdKandang = idKandang;
        }

        public Burung(Guid idBurung, string kodeBurung, string jenisKelamin,
                      DateTime tanggalLahir, string status, Guid idKandang)
        {
            IdBurung = idBurung;
            KodeBurung = kodeBurung;
            JenisKelamin = jenisKelamin;
            TanggalLahir = tanggalLahir;
            Status = status;
            IdKandang = idKandang;
        }
    }
}