using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        
    }
}
