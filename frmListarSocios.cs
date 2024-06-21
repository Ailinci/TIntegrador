using MySql.Data.MySqlClient;
using System.Data;
using TIntegrador.Datos;

namespace TIntegrador
{
    public partial class frmListarSocios : Form
    {
        public frmListarSocios()
        {
            InitializeComponent();
            // Definir las columnas si no están definidas
            if (dtgvSocios.ColumnCount == 0)
            {
                dtgvSocios.Columns.Add("Npostu", "Numero Postulante");
                dtgvSocios.Columns.Add("NombreP", "Nombre");
                dtgvSocios.Columns.Add("ApellidoP", "Apellido");
                dtgvSocios.Columns.Add("TDocP", "Tipo Doc");
                dtgvSocios.Columns.Add("DocP", "Documento");
                dtgvSocios.Columns.Add("Legajo", "Legajo");

            }
            CargarSocios();
        }

        public void CargarSocios()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.GetInstancia().Conectar();
                query = "SELECT p.NPostu, p.NombreP, p.ApellidoP, p.TDocP, p.DocP, " +
               "a.Legajo " +
               "FROM postulante p " +
               "INNER JOIN alumno a ON p.NPostu = a.NPostu " +
               "ORDER BY p.NPostu;";

                MessageBox.Show("Query: " + query); // Añadir esto para depuración

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
                sqlCon.Open();

                MySqlDataReader reader;

                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int reglon = dtgvSocios.Rows.Add();
                        dtgvSocios.Rows[reglon].Cells["Npostu"].Value = reader.GetDecimal(0);
                        dtgvSocios.Rows[reglon].Cells["NombreP"].Value = reader.GetString(1);
                        dtgvSocios.Rows[reglon].Cells["ApellidoP"].Value = reader.GetString(2);
                        dtgvSocios.Rows[reglon].Cells["TDocP"].Value = reader.GetString(3);
                        dtgvSocios.Rows[reglon].Cells["DocP"].Value = reader.GetString(4);
                        dtgvSocios.Rows[reglon].Cells["Legajo"].Value = reader.GetDecimal(5);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
        }

    }
}
