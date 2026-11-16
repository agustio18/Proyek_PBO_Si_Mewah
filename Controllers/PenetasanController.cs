
using System;
using System.Collections.Generic;
using SiMewah.Models;
using SiMewah.Repositories;

namespace SiMewah.Controllers
{
    public class PenetasanController
    {
        private readonly IRepository<Penetasan> _repository;
        private readonly IRepository<Telur> _telurRepository;

        public PenetasanController(
            IRepository<Penetasan> repository,
            IRepository<Telur> telurRepository)
        {
            _repository = repository;
            _telurRepository = telurRepository;
        }

        public void Tambah(Penetasan data)
        {
            Validasi(data);

            Telur? telur = _telurRepository.GetById(data.IdTelur);

            if (telur == null)
            {
                throw new ArgumentException(
                    "Data telur tidak ditemukan.");
            }

            if (GetByIdTelur(data.IdTelur) != null)
            {
                throw new ArgumentException(
                    "Kelompok telur ini sudah memiliki catatan penetasan.");
            }

            ValidasiJumlah(data, telur);

            _repository.Tambah(data);
        }

        public void Ubah(Penetasan data)
        {
            Validasi(data);

            Telur? telur = _telurRepository.GetById(data.IdTelur);

            if (telur == null)
            {
                throw new ArgumentException(
                    "Data telur tidak ditemukan.");
            }

            ValidasiJumlah(data, telur);

            _repository.Ubah(data);
        }

        public Penetasan? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public Penetasan? GetByIdTelur(Guid idTelur)
        {
            foreach (Penetasan data in _repository.GetAll())
            {
                if (data.IdTelur == idTelur)
                {
                    return data;
                }
            }

            return null;
        }

        public List<Penetasan> GetAll()
        {
            return _repository.GetAll();
        }

        private void Validasi(Penetasan data)
        {
            if (data.TanggalPencatatan == default)
            {
                throw new ArgumentException(
                    "Tanggal pencatatan harus diisi.");
            }

            if (data.JumlahMenetas < 0 || data.JumlahGagal < 0)
            {
                throw new ArgumentException(
                    "Jumlah menetas dan gagal tidak boleh negatif.");
            }

            if (data.IdTelur == Guid.Empty)
            {
                throw new ArgumentException(
                    "Data telur harus dipilih.");
            }
        }

        private void ValidasiJumlah(Penetasan data, Telur telur)
        {
            if (data.JumlahMenetas + data.JumlahGagal > telur.JumlahTelur)
            {
                throw new ArgumentException(
                    "Total telur menetas dan gagal tidak boleh melebihi jumlah telur.");
            }
        }
    }
}
