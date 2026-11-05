using Npgsql;
using SiMewah.Data;
using SiMewah.Models;

namespace SiMewah.Repositories
{
    public class PerkawinanRepository : IRepository<Perkawinan>
    {
        public void Tambah(Perkawinan data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                INSERT INTO perkawinan
                (id_perkawinan, tanggal_perkawinan,
                 id_burung_jantan, id_burung_betina)
                VALUES
                (@id, @tanggal, @jantan, @betina)";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdPerkawinan);
            command.Parameters.AddWithValue("@tanggal", data.TanggalPerkawinan);
            command.Parameters.AddWithValue("@jantan", data.IdBurungJantan);
            command.Parameters.AddWithValue("@betina", data.IdBurungBetina);

            command.ExecuteNonQuery();
        }

        public void Ubah(Perkawinan data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                UPDATE perkawinan
                SET tanggal_perkawinan = @tanggal,
                    id_burung_jantan = @jantan,
                    id_burung_betina = @betina
                WHERE id_perkawinan = @id";

            using var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", data.IdPerkawinan);
            command.Parameters.AddWithValue("@tanggal", data.TanggalPerkawinan);
            command.Parameters.AddWithValue("@jantan", data.IdBurungJantan);
            command.Parameters.AddWithValue("@betina", data.IdBurungBetina);

            command.ExecuteNonQuery();
        }

        public Perkawinan? GetById(Guid id)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM perkawinan
                WHERE id_perkawinan = @id";

            using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Perkawinan(
                    reader.GetGuid(0),
                    reader.GetFieldValue<DateOnly>(1),
                    reader.GetGuid(2),
                    reader.GetGuid(3)
                );
            }

            return null;
        }

        public List<Perkawinan> GetAll()
        {
            List<Perkawinan> daftar = new List<Perkawinan>();

            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT *
                FROM perkawinan
                ORDER BY tanggal_perkawinan DESC";

            using var command = new NpgsqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Perkawinan data = new Perkawinan(
                    reader.GetGuid(0),
                    reader.GetFieldValue<DateOnly>(1),
                    reader.GetGuid(2),
                    reader.GetGuid(3)
                );

                daftar.Add(data);
            }

            return daftar;
        }
    }
}
