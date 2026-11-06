
using System;
using System.Collections.Generic;
using SiMewah.Models;
using SiMewah.Repositories;

namespace SiMewah.Controllers
{
    public class TelurController
    {
        private readonly IRepository<Telur> _repository;

        public TelurController(
            IRepository<Telur> repository)
        {
            _repository = repository;
        }

        public void Tambah(Telur data)
        {
            Validasi(data);
            _repository.Tambah(data);
        }

        public void Ubah(Telur data)
        {
            Validasi(data);
            _repository.Ubah(data);
        }

        public Telur? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public List<Telur> GetAll()
        {
            return _repository.GetAll();
        }

        private void Validasi(Telur data)
        {
            if (data.TanggalTelur == default)
            {
                throw new ArgumentException(
                    "Tanggal pencatatan telur harus diisi.");
            }

            if (data.JumlahTelur <= 0)
            {
                throw new ArgumentException(
                    "Jumlah telur harus lebih dari 0.");
            }

            if (data.IdPerkawinan == Guid.Empty)
            {
                throw new ArgumentException(
                    "Data perkawinan harus dipilih.");
            }
        }
    }
}
