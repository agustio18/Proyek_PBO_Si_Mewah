using System;
using System.Collections.Generic;
using SiMewah.Models;
using SiMewah.Repositories;

namespace SiMewah.Controllers
{
    public class BurungController
    {
        private readonly IRepository<Burung> _repository;
        private readonly IRepository<Kandang> _kandangRepository;

        public BurungController(
            IRepository<Burung> repository,
            IRepository<Kandang> kandangRepository)
        {
            _repository = repository;
            _kandangRepository = kandangRepository;
        }

        public void Tambah(Burung data)
        {
            Validasi(data);
            _repository.Tambah(data);
        }

        public void Ubah(Burung data)
        {
            Validasi(data);
            _repository.Ubah(data);
        }

        public Burung? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public List<Burung> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Kandang> GetAllKandang()
        {
            return _kandangRepository.GetAll();
        }

        private void Validasi(Burung data)
        {
            if (string.IsNullOrWhiteSpace(data.KodeBurung))
            {
                throw new ArgumentException(
                    "Kode burung harus diisi.");
            }

            if (data.TanggalLahir == default)
            {
                throw new ArgumentException(
                    "Tanggal lahir harus diisi.");
            }

            if (data.IdKandang == Guid.Empty)
            {
                throw new ArgumentException(
                    "Kandang harus dipilih.");
            }

            if (_kandangRepository.GetById(data.IdKandang) == null)
            {
                throw new ArgumentException(
                    "Kandang tidak ditemukan.");
            }
        }
    }
}
