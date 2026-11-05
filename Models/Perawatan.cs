using System;
namespace SiMewah.Models
{
    public class Perawatan
    {
        public Guid IdPerawatan { get; set; }
        public string JenisPerawatan { get; set; }
        public DateTime TanggalPerawatan { get; set; }
        public int JumlahPerawatan { get; set; }
        public Guid IdBurung { get; set; }
        public bool IsDelete { get; set; }
    }
}