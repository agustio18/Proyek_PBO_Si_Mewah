<<<<<<< HEAD
using System;
using System.Collections.Generic;
using SiMewah.Models;
using SiMewah.Repositories;

=======
>>>>>>> b942a07 (update Form produksi)
namespace SiMewah.Controllers
{
    public class KandangController
    {
        private readonly IRepository<Kandang> _repository;

        public KandangController(
            IRepository<Kandang> repository)
        {
            _repository = repository;
        }

        public void Tambah(Kandang data)
        {
            Validasi(data);
            _repository.Tambah(data);
        }

        public void Ubah(Kandang data)
        {
            Validasi(data);
            _repository.Ubah(data);
        }

        public Kandang? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public List<Kandang> GetAll()
        {
            return _repository.GetAll();
        }

        private void Validasi(Kandang data)
        {
            if (string.IsNullOrWhiteSpace(data.JenisKandang))
            {
                throw new ArgumentException(
                    "Jenis kandang harus diisi.");
            }
        }
    }
}
