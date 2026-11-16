using System;
using System.Collections.Generic;
using SiMewah.Models;
using SiMewah.Repositories;

namespace SiMewah.Controllers
{
    public class PerawatanController
    {
        private readonly IRepository<Perawatan> _repository;
        private readonly IRepository<Burung> _burungRepository;

        public PerawatanController(
            IRepository<Perawatan> repository,
            IRepository<Burung> burungRepository)
        {
            _repository = repository;
            _burungRepository = burungRepository;
        }

        public void Tambah(Perawatan data)
        {
            Validasi(data);
            _repository.Tambah(data);
        }

        public void Ubah(Perawatan data)
        {
            Validasi(data);
            _repository.Ubah(data);
        }

        public void Hapus(Guid id)
        {
            Perawatan? data = _repository.GetById(id);

            if (data == null)
            {
                throw new ArgumentException("Data perawatan tidak ditemukan.");
            }

            data.IsDelete = true;
            _repository.Ubah(data);
        }

        public Perawatan? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public List<Perawatan> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Burung> GetAllBurung()
        {
            return _burungRepository.GetAll();
        }

        private void Validasi(Perawatan data)
        {
            if (data.JenisPerawatan != "Pemberian Pakan" &&
                data.JenisPerawatan != "Pemberian Vitamin")
            {
                throw new ArgumentException(
                    "Jenis perawatan harus dipilih.");
            }

            if (data.TanggalPerawatan == default)
            {
                throw new ArgumentException(
                    "Tanggal perawatan harus diisi.");
            }

            if (data.TanggalPerawatan > DateOnly.FromDateTime(DateTime.Today))
            {
                throw new ArgumentException(
                    "Tanggal perawatan tidak boleh melebihi hari ini.");
            }

            if (data.JumlahPerawatan <= 0)
            {
                throw new ArgumentException(
                    "Jumlah perawatan harus lebih dari 0.");
            }

            if (data.IdBurung == Guid.Empty)
            {
                throw new ArgumentException(
                    "Burung harus dipilih.");
            }

            if (_burungRepository.GetById(data.IdBurung) == null)
            {
                throw new ArgumentException(
                    "Burung tidak ditemukan.");
            }
        }
    }
}
