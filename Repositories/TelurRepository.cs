using Npgsql;
using SiMewah.Data;
using SiMewah.Models;

namespace SiMewah.Repositories
{
    public class TelurRepository : IRepository<Telur>
    {
        public void Tambah(Telur data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                INSERT INTO telur
                (id_telur, tanggal_telur, jumlah_telur, id_perkawinan)
                VALUES
                (@id, @tanggal, @jumlah, @perkawinan)";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdTelur);
            command.Parameters.AddWithValue("@tanggal", data.TanggalTelur);
            command.Parameters.AddWithValue("@jumlah", data.JumlahTelur);
            command.Parameters.AddWithValue("@perkawinan", data.IdPerkawinan);

            command.ExecuteNonQuery();
        }

        public void Ubah(Telur data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                UPDATE telur
                SET jumlah_telur = @jumlah
                WHERE id_telur = @id";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdTelur);
            command.Parameters.AddWithValue("@jumlah", data.JumlahTelur);

            command.ExecuteNonQuery();
        }

        public Telur? GetById(Guid id)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM telur
                WHERE id_telur = @id";

            using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Telur(
                    reader.GetGuid(0),
                    reader.GetFieldValue<DateOnly>(1),
                    reader.GetInt32(2),
                    reader.GetGuid(3)
                );
            }

            return null;
        }

        public List<Telur> GetAll()
        {
            List<Telur> daftar = new List<Telur>();

            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM telur
                ORDER BY tanggal_telur DESC";

            using var command = new NpgsqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Telur data = new Telur(
                    reader.GetGuid(0),
                    reader.GetFieldValue<DateOnly>(1),
                    reader.GetInt32(2),
                    reader.GetGuid(3)
                );

                daftar.Add(data);
            }

            return daftar;
        }
    }
}
