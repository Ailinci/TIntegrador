using MySql.Data.MySqlClient;

namespace TIntegrador.Datos
{
    internal class Conexion
    {
        private string basedatos;
        private string servidor;
        private string usuario;
        private string contrasena;
        private static Conexion? con = null;

        private Conexion()
        {
            basedatos = "baseclub";
            servidor = "localhost";
            usuario = "root";
            contrasena = "contraseña";
        }

        public MySqlConnection Conectar()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = $"server={servidor}; database={basedatos}; Uid={usuario}; pwd={contrasena}";
                cadena.Open();
                return cadena;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;

        }
        public static Conexion GetInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
