using System;
using System.Collections.Generic;
using SiMewah.Models;
using SiMewah.Repositories;

namespace SiMewah.Controllers
{
    public class PerkawinanController
    {
        private readonly IRepository<Perkawinan> _repository;

        public PerkawinanController(
            IRepository<Perkawinan> repository)
        {
            _repository = repository;
        }

        public void Tambah(Perkawinan data)
        {
            Validasi(data);
            _repository.Tambah(data);
        }

        public void Ubah(Perkawinan data)
        {
            Validasi(data);
            _repository.Ubah(data);
        }

        public Perkawinan? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public List<Perkawinan> GetAll()
        {
            return _repository.GetAll();
        }

        private void Validasi(Perkawinan data)
        {
            if (data.TanggalPerkawinan == default)
            {
                throw new ArgumentException(
                    "Tanggal perkawinan harus diisi.");
            }

            if (data.IdBurungJantan == Guid.Empty ||
                data.IdBurungBetina == Guid.Empty)
            {
                throw new ArgumentException(
                    "Burung jantan dan betina harus dipilih.");
            }

            if (data.IdBurungJantan == data.IdBurungBetina)
            {
                throw new ArgumentException(
                    "Burung jantan dan betina tidak boleh sama.");
            }
        }
    }
}
