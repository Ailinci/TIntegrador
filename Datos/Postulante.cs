using MySql.Data.MySqlClient;
using System.Data;
using TIntegrador.Entidades;

namespace TIntegrador.Datos
{
    internal class Postulantes
    {
        public string Nuevo_Postu(E_Postulante postu)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().Conectar();
                MySqlCommand comando = new MySqlCommand("NuevoPos",
                sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value =
                postu.NombreP;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value =
                postu.ApellidoP;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value =
                postu.TDocP;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value =
                postu.DocP;
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }


        public string BuscarPostulante(E_Postulante postu)
        {
            string salida = string.Empty;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().Conectar();
                MySqlCommand comando = new MySqlCommand("BuscarPostulante", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = postu.TDocP;
                comando.Parameters.Add("Doc", MySqlDbType.Int64).Value = postu.DocP; // Assuming BIGINT

                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Assuming you want to return the first column value as a string
                        salida = $"Número de postulante: {reader.GetString("NPostu")}\n" +
                                 $"Nombre: {reader.GetString("NombreP")}\n" +
                                 $"Apellido: {reader.GetString("ApellidoP")}\n" +
                                 $"Tipo de Documento: {reader.GetString("TDocP")}\n" +
                                 $"Documento: {reader.GetString("DocP")}";
                    }
                }
                else
                {
                    salida = "No data found";
                }
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }

    }


}
