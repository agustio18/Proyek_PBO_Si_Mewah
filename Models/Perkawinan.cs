using System;
using System.Collections.Generic;
using System.Text;


namespace SiMewah.Models
{
    public class Perkawinan
    {
        public Guid IdPerkawinan { get; private set; }
        public DateOnly TanggalPerkawinan { get; set; }
        public Guid IdBurungJantan { get; set; }
        public Guid IdBurungBetina { get; set; }

        public Perkawinan(
            DateOnly tanggalPerkawinan,
            Guid idBurungJantan,
            Guid idBurungBetina)
        {
            IdPerkawinan = Guid.NewGuid();
            TanggalPerkawinan = tanggalPerkawinan;
            IdBurungJantan = idBurungJantan;
            IdBurungBetina = idBurungBetina;
        }
    }
}
