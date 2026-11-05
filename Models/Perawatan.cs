using System;
<<<<<<< HEAD
namespace Perawatan.Models
=======
namespace Proyek_PBO___Si_Mewah.Models
>>>>>>> 9207717e258d669419fe59ac6bfcc8545955386c
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