using System;

namespace SiMewah.Models
{
    public class Perawatan
    {
        public Guid IdPerawatan { get; private set; }
        public string JenisPerawatan { get; set; }
        public DateOnly TanggalPerawatan { get; set; }
        public int JumlahPerawatan { get; set; }
        public Guid IdBurung { get; set; }
        public bool IsDelete { get; set; }

        public Perawatan(
            string jenisPerawatan,
            DateOnly tanggalPerawatan,
            int jumlahPerawatan,
            Guid idBurung)
            : this(
                Guid.NewGuid(),
                jenisPerawatan,
                tanggalPerawatan,
                jumlahPerawatan,
                idBurung,
                false)
        {
        }

        public Perawatan(
            Guid idPerawatan,
            string jenisPerawatan,
            DateOnly tanggalPerawatan,
            int jumlahPerawatan,
            Guid idBurung,
            bool isDelete)
        {
            IdPerawatan = idPerawatan;
            JenisPerawatan = jenisPerawatan;
            TanggalPerawatan = tanggalPerawatan;
            JumlahPerawatan = jumlahPerawatan;
            IdBurung = idBurung;
            IsDelete = isDelete;
        }
    }
}
