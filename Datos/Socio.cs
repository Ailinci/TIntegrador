using MySql.Data.MySqlClient;
using System.Data;
using TIntegrador.Entidades;

namespace TIntegrador.Datos
{
    internal class Socio
    {
        public string Nuevo_Socio(E_Socio socio)
        {
        
                string salida;
                MySqlConnection sqlCon = new MySqlConnection();
                try
                {
                    sqlCon = Conexion.GetInstancia().Conectar();
                    MySqlCommand comando = new MySqlCommand("CrearAlumno", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new MySqlParameter("@p_NomP", MySqlDbType.VarChar)).Value = socio.NombreP;
                    comando.Parameters.Add(new MySqlParameter("@p_ApeP", MySqlDbType.VarChar)).Value = socio.ApellidoP;
                    comando.Parameters.Add(new MySqlParameter("@p_TDocP", MySqlDbType.VarChar)).Value = socio.TDocP;
                    comando.Parameters.Add(new MySqlParameter("@p_DocP", MySqlDbType.Int64)).Value = socio.DocP;

                    MySqlParameter p_Legajo = new MySqlParameter("@p_Legajo", MySqlDbType.Int32);
                    p_Legajo.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(p_Legajo);

                    MySqlParameter p_Resultado = new MySqlParameter("@p_Resultado", MySqlDbType.VarChar, 100);
                    p_Resultado.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(p_Resultado);

                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();

                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                    // Obtener resultados de las variables de salida
                    string resultado = p_Resultado.Value.ToString();
                    int legajo = Convert.ToInt32(p_Legajo.Value);

                    salida = resultado;
                }
                catch (Exception ex)
                {
                    salida = ex.Message;
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
                return salida;
            }
        
        public string Buscar_Socio(E_Socio socio)
        {
            string salida = string.Empty;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().Conectar();
                MySqlCommand comando = new MySqlCommand("BuscarPostulante", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = socio.TDocP;
                comando.Parameters.Add("Doc", MySqlDbType.Int64).Value = socio.DocP; // Assuming BIGINT

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
                        salida = $"Número de socio: {reader.GetString("NPostu")}\n" +
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

        public string GenerarIdRegistro(E_Socio socio)
        {
            string salida = string.Empty;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().Conectar();
                MySqlCommand comando = new MySqlCommand("AgregarInscripcion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = socio.TDocP;
                comando.Parameters.Add("Doc", MySqlDbType.Int64).Value = socio.DocP; // Assuming BIGINT

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
                        salida = $"ID de la Inscripción: {reader.GetInt32("idInscripcion")}\n" +
                                 $"ID del Pago: {reader.GetInt32("idPago")}\n" +
                                 $"Monto del Pago: {reader.GetFloat("montoPago")}\n" +
                                 $"Fecha del Pago: {reader.GetDateTime("fechaPago").ToString("yyyy-MM-dd")}";
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
