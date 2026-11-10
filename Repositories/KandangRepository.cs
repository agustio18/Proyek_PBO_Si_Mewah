using Npgsql;
using SiMewah.Data;
using SiMewah.Models;

namespace SiMewah.Repositories
{
    public class KandangRepository : IRepository<Kandang>
    {
        public void Tambah(Kandang data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                INSERT INTO kandang
                (id_kandang, jenis_kandang, keterangan)
                VALUES
                (@id, @jenis, @keterangan)";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdKandang);
            command.Parameters.AddWithValue("@jenis", data.JenisKandang);
            command.Parameters.AddWithValue("@keterangan", (object?)data.Keterangan ?? DBNull.Value);

            command.ExecuteNonQuery();
        }

        public void Ubah(Kandang data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                UPDATE kandang
                SET jenis_kandang = @jenis,
                    keterangan = @keterangan
                WHERE id_kandang = @id";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdKandang);
            command.Parameters.AddWithValue("@jenis", data.JenisKandang);
            command.Parameters.AddWithValue("@keterangan", (object?)data.Keterangan ?? DBNull.Value);

            command.ExecuteNonQuery();
        }

        public Kandang? GetById(Guid id)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM kandang
                WHERE id_kandang = @id";

            using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Kandang(
                    reader.GetGuid(0),
                    reader.GetString(1),
                    reader.IsDBNull(2) ? null : reader.GetString(2)
                );
            }

            return null;
        }

        public List<Kandang> GetAll()
        {
            List<Kandang> daftar = new List<Kandang>();

            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM kandang
                ORDER BY jenis_kandang";

            using var command = new NpgsqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Kandang data = new Kandang(
                    reader.GetGuid(0),
                    reader.GetString(1),
                    reader.IsDBNull(2) ? null : reader.GetString(2)
                );

                daftar.Add(data);
            }

            return daftar;
        }
    }
}
