namespace SiMewah.Repositories
{
    public interface IRepository<T>
    {
        void Tambah(T data);
        void Ubah(T data);
        T? GetById(Guid id);
        List<T> GetAll();
    }
}




