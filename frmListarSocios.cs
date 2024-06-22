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
                dtgvSocios.Columns.Add("UltimoPagoFecha", "Ultimo Pago Fecha");
                dtgvSocios.Columns.Add("UltimoPagoMonto", "Ultimo Pago Monto");
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
                query = "SELECT p.NPostu, p.NombreP, p.ApellidoP, p.TDocP, p.DocP, a.Legajo, " +
                        "COALESCE(MAX(pg.fecha), 'No hay pagos') AS UltimoPagoFecha, " +
                        "COALESCE(MAX(pg.monto), 0) AS UltimoPagoMonto " +
                        "FROM postulante p " +
                        "INNER JOIN alumno a ON p.NPostu = a.NPostu " +
                        "LEFT JOIN inscripcion i ON a.Legajo = i.Legajo " +
                        "LEFT JOIN pago pg ON i.idInscri = pg.idInscri " +
                        "GROUP BY p.NPostu, p.NombreP, p.ApellidoP, p.TDocP, p.DocP, a.Legajo " +
                        "ORDER BY p.NPostu;";

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
                        dtgvSocios.Rows[reglon].Cells["Npostu"].Value = Convert.ToString(reader["NPostu"]);
                        dtgvSocios.Rows[reglon].Cells["NombreP"].Value = Convert.ToString(reader["NombreP"]);
                        dtgvSocios.Rows[reglon].Cells["ApellidoP"].Value = Convert.ToString(reader["ApellidoP"]);
                        dtgvSocios.Rows[reglon].Cells["TDocP"].Value = Convert.ToString(reader["TDocP"]);
                        dtgvSocios.Rows[reglon].Cells["DocP"].Value = Convert.ToString(reader["DocP"]);
                        dtgvSocios.Rows[reglon].Cells["Legajo"].Value = Convert.ToString(reader["Legajo"]);

                        // Leer y asignar la fecha del último pago
                        object ultimoPagoFecha = reader["UltimoPagoFecha"];
                        if (ultimoPagoFecha is DateTime)
                        {
                            dtgvSocios.Rows[reglon].Cells["UltimoPagoFecha"].Value = ((DateTime)ultimoPagoFecha).ToShortDateString();
                        }
                        else if (ultimoPagoFecha is string)
                        {
                            dtgvSocios.Rows[reglon].Cells["UltimoPagoFecha"].Value = (string)ultimoPagoFecha;
                        }
                        else
                        {
                            dtgvSocios.Rows[reglon].Cells["UltimoPagoFecha"].Value = "No hay pagos";
                        }

                        // Leer y asignar el monto del último pago
                        object ultimoPagoMonto = reader["UltimoPagoMonto"];
                        if (ultimoPagoMonto == DBNull.Value)
                        {
                            dtgvSocios.Rows[reglon].Cells["UltimoPagoMonto"].Value = "0";
                        }
                        else
                        {
                            dtgvSocios.Rows[reglon].Cells["UltimoPagoMonto"].Value = Convert.ToDecimal(ultimoPagoMonto).ToString();
                        }
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


        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form principal = new Form2();
            principal.Show();
            this.Close();
        }
    }

}
