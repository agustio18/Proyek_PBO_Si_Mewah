using Npgsql;
using SiMewah.Data;
using SiMewah.Models;

namespace SiMewah.Repositories
{
    public class PerawatanRepository : IRepository<Perawatan>
    {
        public void Tambah(Perawatan data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                INSERT INTO perawatan
                (id_perawatan, jenis_perawatan, tanggal_perawatan,
                 jumlah_perawatan, id_burung, is_delete)
                VALUES
                (@id, @jenis, @tanggal, @jumlah, @burung, @isDelete)";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdPerawatan);
            command.Parameters.AddWithValue("@jenis", data.JenisPerawatan);
            command.Parameters.AddWithValue("@tanggal", data.TanggalPerawatan);
            command.Parameters.AddWithValue("@jumlah", data.JumlahPerawatan);
            command.Parameters.AddWithValue("@burung", data.IdBurung);
            command.Parameters.AddWithValue("@isDelete", data.IsDelete);

            command.ExecuteNonQuery();
        }

        public void Ubah(Perawatan data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                UPDATE perawatan
                SET jenis_perawatan = @jenis,
                    tanggal_perawatan = @tanggal,
                    jumlah_perawatan = @jumlah,
                    id_burung = @burung,
                    is_delete = @isDelete
                WHERE id_perawatan = @id";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdPerawatan);
            command.Parameters.AddWithValue("@jenis", data.JenisPerawatan);
            command.Parameters.AddWithValue("@tanggal", data.TanggalPerawatan);
            command.Parameters.AddWithValue("@jumlah", data.JumlahPerawatan);
            command.Parameters.AddWithValue("@burung", data.IdBurung);
            command.Parameters.AddWithValue("@isDelete", data.IsDelete);

            command.ExecuteNonQuery();
        }

        public Perawatan? GetById(Guid id)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT id_perawatan, jenis_perawatan, tanggal_perawatan,
                       jumlah_perawatan, id_burung, is_delete
                FROM perawatan
                WHERE id_perawatan = @id
                  AND is_delete = FALSE";

            using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Perawatan(
                    reader.GetGuid(0),
                    reader.GetString(1),
                    reader.GetFieldValue<DateOnly>(2),
                    reader.GetInt32(3),
                    reader.GetGuid(4),
                    reader.GetBoolean(5)
                );
            }

            return null;
        }

        public List<Perawatan> GetAll()
        {
            List<Perawatan> daftar = new List<Perawatan>();

            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT id_perawatan, jenis_perawatan, tanggal_perawatan,
                       jumlah_perawatan, id_burung, is_delete
                FROM perawatan
                WHERE is_delete = FALSE
                ORDER BY tanggal_perawatan DESC";

            using var command = new NpgsqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Perawatan data = new Perawatan(
                    reader.GetGuid(0),
                    reader.GetString(1),
                    reader.GetFieldValue<DateOnly>(2),
                    reader.GetInt32(3),
                    reader.GetGuid(4),
                    reader.GetBoolean(5)
                );

                daftar.Add(data);
            }

            return daftar;
        }
    }
}
