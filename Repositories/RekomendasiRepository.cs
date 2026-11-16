using System;
using System.Collections.Generic;
using Npgsql;
using SiMewah.Data;
using SiMewah.Models;

namespace SiMewah.Repositories
{
    public class RekomendasiRepository
    {
        public List<KeyValuePair<Guid, string>> GetDaftarBurungBetina()
        {
            var list = new List<KeyValuePair<Guid, string>>();
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "SELECT id_burung, kode_burung FROM burung WHERE jenis_kelamin = 'betina' AND status = 'aktif';";
            using var command = new NpgsqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new KeyValuePair<Guid, string>(
                    reader.GetGuid(0),
                    reader.GetString(1)
                ));
            }
            return list;
        }

        public DataEvaluasiBurung GetDataEvaluasi(Guid idBurungBetina)
        {
            var data = new DataEvaluasiBurung { IdBurung = idBurungBetina };
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            // 1. Tarik data Breeding (Perkawinan -> Telur -> Penetasan)
            string sqlBreeding = @"
                SELECT 
                    COUNT(p.id_penetasan) AS total_siklus,
                    COALESCE(SUM(t.jumlah_telur), 0) AS total_telur,
                    COALESCE(SUM(p.jumlah_menetas), 0) AS total_menetas
                FROM perkawinan pk
                JOIN telur t ON pk.id_perkawinan = t.id_perkawinan
                JOIN penetasan p ON t.id_telur = p.id_telur
                WHERE pk.id_burung_betina = @idBurung;";

            using (var cmd = new NpgsqlCommand(sqlBreeding, connection))
            {
                cmd.Parameters.AddWithValue("@idBurung", idBurungBetina);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    data.TotalSiklus = Convert.ToInt32(reader["total_siklus"]);
                    data.TotalTelur = Convert.ToInt32(reader["total_telur"]);
                    data.TotalMenetas = Convert.ToInt32(reader["total_menetas"]);
                }
            }

            // 2. Tarik data Perawatan 30 hari terakhir
            string sqlPerawatan = @"
                SELECT 
                    COUNT(*) FILTER (WHERE jenis_perawatan = 'Pemberian Vitamin') AS jml_vitamin,
                    COUNT(*) FILTER (WHERE jenis_perawatan = 'Pemberian Pakan') AS jml_pakan
                FROM perawatan
                WHERE id_burung = @idBurung 
                  AND is_delete = FALSE
                  AND tanggal_perawatan >= CURRENT_DATE - INTERVAL '30 days';";

            using (var cmd = new NpgsqlCommand(sqlPerawatan, connection))
            {
                cmd.Parameters.AddWithValue("@idBurung", idBurungBetina);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    data.JumlahVitaminBulanIni = Convert.ToInt32(reader["jml_vitamin"]);
                    data.JumlahPakanBulanIni = Convert.ToInt32(reader["jml_pakan"]);
                }
            }

            return data;
        }

        public void Tambah(Rekomendasi data)
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                INSERT INTO rekomendasi 
                (id_rekomendasi, tanggal_rekomendasi, hasil_rekomendasi, keterangan, id_burung, id_perawatan, id_perkawinan, id_telur, id_penetasan)
                VALUES 
                (@id, @tanggal, @hasil, @keterangan, @idBurung, NULL, NULL, NULL, NULL);";

            using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", data.IdRekomendasi);
            command.Parameters.AddWithValue("@tanggal", data.TanggalRekomendasi);
            command.Parameters.AddWithValue("@hasil", data.HasilRekomendasi);
            command.Parameters.AddWithValue("@keterangan", (object)data.Keterangan ?? DBNull.Value);
            command.Parameters.AddWithValue("@idBurung", data.IdBurung);

            command.ExecuteNonQuery();
        }

        public List<Rekomendasi> GetByBurung(Guid idBurungBetina)
        {
            var daftar = new List<Rekomendasi>();
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = @"
                SELECT id_rekomendasi, tanggal_rekomendasi, hasil_rekomendasi, keterangan, id_burung
                FROM rekomendasi
                WHERE id_burung = @idBurung
                ORDER BY tanggal_rekomendasi DESC;";

            using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@idBurung", idBurungBetina);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                daftar.Add(new Rekomendasi
                {
                    IdRekomendasi = reader.GetGuid(0),
                    TanggalRekomendasi = reader.GetDateTime(1),
                    HasilRekomendasi = reader.GetString(2),
                    Keterangan = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    IdBurung = reader.GetGuid(4)
                });
            }
            return daftar;
        }
    }
}