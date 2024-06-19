using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pruebaTp
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
            this.basedatos = "baseclub";
            this.servidor = "localhost";
            this.usuario = "root";
            this.contrasena = "Root13";
        }

        public MySqlConnection Conectar()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = $"server={this.servidor}; database={this.basedatos}; Uid={this.usuario}; pwd={this.contrasena}";
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
