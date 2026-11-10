using Npgsql;
using SiMewah.Data;
using SiMewah.Models;

namespace SiMewah.Repositories
{
    public class BurungRepository : IRepository<Burung>
    {
        public void Tambah(Burung data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                INSERT INTO burung
                (id_burung, kode_burung, jenis_kelamin,
                 tanggal_lahir, status, id_kandang)
                VALUES
                (@id, @kode, @jenisKelamin, @tanggalLahir, @status, @kandang)";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdBurung);
            command.Parameters.AddWithValue("@kode", data.KodeBurung);
            command.Parameters.AddWithValue("@jenisKelamin", data.JenisKelamin);
            command.Parameters.AddWithValue("@tanggalLahir", data.TanggalLahir);
            command.Parameters.AddWithValue("@status", data.Status);
            command.Parameters.AddWithValue("@kandang", data.IdKandang);

            command.ExecuteNonQuery();
        }

        public void Ubah(Burung data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                UPDATE burung
                SET kode_burung = @kode,
                    jenis_kelamin = @jenisKelamin,
                    tanggal_lahir = @tanggalLahir,
                    status = @status,
                    id_kandang = @kandang
                WHERE id_burung = @id";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdBurung);
            command.Parameters.AddWithValue("@kode", data.KodeBurung);
            command.Parameters.AddWithValue("@jenisKelamin", data.JenisKelamin);
            command.Parameters.AddWithValue("@tanggalLahir", data.TanggalLahir);
            command.Parameters.AddWithValue("@status", data.Status);
            command.Parameters.AddWithValue("@kandang", data.IdKandang);

            command.ExecuteNonQuery();
        }

        public Burung? GetById(Guid id)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM burung
                WHERE id_burung = @id";

            using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Burung(
                    reader.GetGuid(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetFieldValue<DateOnly>(3),
                    reader.GetString(4),
                    reader.GetGuid(5)
                );
            }

            return null;
        }

        public List<Burung> GetAll()
        {
            List<Burung> daftar = new List<Burung>();

            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM burung
                ORDER BY kode_burung";

            using var command = new NpgsqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Burung data = new Burung(
                    reader.GetGuid(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetFieldValue<DateOnly>(3),
                    reader.GetString(4),
                    reader.GetGuid(5)
                );

                daftar.Add(data);
            }

            return daftar;
        }
    }
}
