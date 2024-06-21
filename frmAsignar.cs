using MySql.Data.MySqlClient;
using System.Data;
using TIntegrador.Datos;

namespace TIntegrador
{
    public partial class frmAsignar : Form
    {
        public frmAsignar()
        {
            InitializeComponent();
        }
        private void frmAsignar_Load(object sender, EventArgs e)
        {
            // Definir las columnas si no están definidas
            if (dtgvCurso.ColumnCount == 0)
            {
                dtgvCurso.Columns.Add("NombreCurso", "Nombre del Curso");
                dtgvCurso.Columns.Add("Fecha", "Fecha");
                dtgvCurso.Columns.Add("Docente", "Docente");
                dtgvCurso.Columns.Add("Precio", "Precio");
            }

            CargarGrilla();

        }
        public void CargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.GetInstancia().Conectar();
                query = "SELECT c.nombre, " +
                        "e.fecha, " +
                        "CONCAT(d.NombreD, ', ', d.ApellidoD) AS docente, " +
                        "c.precio " +
                        "FROM curso c " +
                        "INNER JOIN edicion e ON c.NCurso = e.NCurso " +
                        "INNER JOIN docente d ON e.docente = d.NDocente " +
                        "WHERE e.fecha > CURDATE() " +
                        "ORDER BY c.nombre;";

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

                        int reglon = dtgvCurso.Rows.Add();
                        dtgvCurso.Rows[reglon].Cells["NombreCurso"].Value = reader.GetString(0);
                        dtgvCurso.Rows[reglon].Cells["Fecha"].Value = reader.GetDateTime(1).ToString("yyyy-MM-dd"); // Ajusta el formato de fecha según necesites
                        dtgvCurso.Rows[reglon].Cells["Docente"].Value = reader.GetString(2);
                        dtgvCurso.Rows[reglon].Cells["Precio"].Value = reader.GetDecimal(3);

                    }
                }
                else
                { MessageBox.Show("NO HAY DATOS PARA LA CARGADE LA GRILLA"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
        }

        private void dtgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que el clic sea en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dtgvCurso.Rows[e.RowIndex];

                // Obtener información del curso de la fila seleccionada
                string nombreCurso = filaSeleccionada.Cells["NombreCurso"].Value.ToString();
                string fecha = filaSeleccionada.Cells["Fecha"].Value.ToString();
                string docente = filaSeleccionada.Cells["Docente"].Value.ToString();
                string precio = filaSeleccionada.Cells["Precio"].Value.ToString();

                // Aquí puedes implementar la lógica para relacionar el curso con un usuario
                // Por ejemplo, mostrar un cuadro de diálogo para ingresar el DNI del usuario
                // y luego realizar la operación necesaria (ejemplo no incluido)
                MessageBox.Show($"Curso seleccionado: {nombreCurso}\nFecha: {fecha}\nDocente: {docente}\nPrecio: {precio}", "Información del Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dtgvCurso_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form atras = new Form2();
            atras.Show();
            this.Close();
        }
    }
}
