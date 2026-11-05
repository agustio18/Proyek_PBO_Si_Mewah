using System;
using System.Collections.Generic;
using System.Text;

namespace Penetasan.Models
{
    public class Penetasan
    {
        public Guid IdPenetasan { get; private set; }
        public DateOnly TanggalPencatatan { get; set; }
        public int JumlahMenetas { get; set; }
        public int JumlahGagal { get; set; }
        public Guid IdTelur { get; set; }

        public Penetasan(
            DateOnly tanggalPencatatan,
            int jumlahMenetas,
            int jumlahGagal,
            Guid idTelur)
        {
            IdPenetasan = Guid.NewGuid();
            TanggalPencatatan = tanggalPencatatan;
            JumlahMenetas = jumlahMenetas;
            JumlahGagal = jumlahGagal;
            IdTelur = idTelur;
        }
    }
}
