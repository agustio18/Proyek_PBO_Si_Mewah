using Npgsql;
using SiMewah.Data;
using SiMewah.Models;

namespace SiMewah.Repositories
{
    public class PenetasanRepository : IRepository<Penetasan>
    {
        public void Tambah(Penetasan data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                INSERT INTO penetasan
                (id_penetasan, tanggal_pencatatan,
                 jumlah_menetas, jumlah_gagal, id_telur)
                VALUES
                (@id, @tanggal, @menetas, @gagal, @telur)";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdPenetasan);
            command.Parameters.AddWithValue("@tanggal", data.TanggalPencatatan);
            command.Parameters.AddWithValue("@menetas", data.JumlahMenetas);
            command.Parameters.AddWithValue("@gagal", data.JumlahGagal);
            command.Parameters.AddWithValue("@telur", data.IdTelur);

            command.ExecuteNonQuery();
        }

        public void Ubah(Penetasan data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                UPDATE penetasan
                SET jumlah_menetas = @menetas,
                    jumlah_gagal = @gagal
                WHERE id_penetasan = @id";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdPenetasan);
            command.Parameters.AddWithValue("@menetas", data.JumlahMenetas);
            command.Parameters.AddWithValue("@gagal", data.JumlahGagal);

            command.ExecuteNonQuery();
        }

        public Penetasan? GetById(Guid id)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM penetasan
                WHERE id_penetasan = @id";

            using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Penetasan(
                    reader.GetGuid(0),
                    reader.GetFieldValue<DateOnly>(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetGuid(4)
                );
            }

            return null;
        }

        public Penetasan? GetByIdTelur(Guid idTelur)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM penetasan
                WHERE id_telur = @idTelur";

            using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@idTelur", idTelur);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Penetasan(
                    reader.GetGuid(0),
                    reader.GetFieldValue<DateOnly>(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetGuid(4)
                );
            }

            return null;
        }

        public List<Penetasan> GetAll()
        {
            List<Penetasan> daftar = new List<Penetasan>();

            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM penetasan
                ORDER BY tanggal_pencatatan DESC";

            using var command = new NpgsqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Penetasan data = new Penetasan(
                    reader.GetGuid(0),
                    reader.GetFieldValue<DateOnly>(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetGuid(4)
                );

                daftar.Add(data);
            }

            return daftar;
        }
    }
}
