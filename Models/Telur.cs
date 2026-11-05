using System;
using System.Collections.Generic;
using System.Text;


namespace SiMewah.Models
{
    public class Telur
    {
        public Guid IdTelur { get; private set; }
        public DateOnly TanggalTelur { get; set; }
        public int JumlahTelur { get; set; }
        public Guid IdPerkawinan { get; set; }

        public Telur(
            DateOnly tanggalTelur,
            int jumlahTelur,
            Guid idPerkawinan)
        {
            IdTelur = Guid.NewGuid();
            TanggalTelur = tanggalTelur;
            JumlahTelur = jumlahTelur;
            IdPerkawinan = idPerkawinan;
        }

        public Telur(
            Guid idTelur,
            DateOnly tanggalTelur,
            int jumlahTelur,
            Guid idPerkawinan)
        {
            IdTelur = idTelur;
            TanggalTelur = tanggalTelur;
            JumlahTelur = jumlahTelur;
            IdPerkawinan = idPerkawinan;
        }
    }
}
