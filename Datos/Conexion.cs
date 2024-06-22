using MySql.Data.MySqlClient;

namespace TIntegrador.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion() // asignamos valores a las variables de la conexion
        {
            // variables usadas para larepetición de líneas de código
            bool correcto = false;
            int mensaje;

            string T_servidor = "Servidor" ;
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave"; // se antepuso la T para indica que vienen desde TECLADO

            while (correcto != true)
            {
            // Armamos los cuadros de dialogo para el ingreso de datos
            T_servidor = Microsoft.VisualBasic.Interaction.InputBox("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
            T_puerto = Microsoft.VisualBasic.Interaction.InputBox("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
            T_usuario = Microsoft.VisualBasic.Interaction.InputBox("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
            T_clave = Microsoft.VisualBasic.Interaction.InputBox("ingrese clave", "DATOS DE INSTALACIÓN MySQL");

            mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " +
            T_servidor + " PUERTO= " + T_puerto + " USUARIO: " +
            T_usuario + " CLAVE: " + T_clave,
            "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (mensaje != 6) // el valor 6 corresponde al SI
            {
                MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                correcto = false;
            }
            else
            {
                correcto = true;
            }
            }
            // reemplazamos los datos concretos que teniamos por las variables
            this.baseDatos = "baseclub";
            this.servidor = T_servidor; // "localhost";
            this.puerto = T_puerto; //"3306";
            this.usuario = T_usuario; // "root";
            this.clave = T_clave; // "";
            }

        public MySqlConnection Conectar()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = $"server={servidor}; database={baseDatos}; Uid={usuario}; pwd={clave}";
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
