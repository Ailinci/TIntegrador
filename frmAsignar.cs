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
                dtgvCurso.Columns.Add("NCurso", "ID del Curso");
                dtgvCurso.Columns.Add("NombreCurso", "Nombre del Curso");
                dtgvCurso.Columns.Add("Fecha", "Fecha");
                dtgvCurso.Columns.Add("Docente", "Docente");
                dtgvCurso.Columns.Add("Precio", "Precio");

                // Añadir la columna del botón
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Seleccionar";
                btnColumn.HeaderText = "Seleccionar Curso";
                btnColumn.Text = "Seleccionar";
                btnColumn.UseColumnTextForButtonValue = true;
                dtgvCurso.Columns.Add(btnColumn);
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
                query = "SELECT c.NCurso, c.nombre, " +
                        "e.fecha, " +
                        "CONCAT(d.NombreD, ', ', d.ApellidoD) AS docente, " +
                        "c.precio " +
                        "FROM curso c " +
                        "INNER JOIN edicion e ON c.NCurso = e.NCurso " +
                        "INNER JOIN docente d ON e.docente = d.NDocente " +
                        "WHERE e.fecha > CURDATE() " +
                        "ORDER BY c.nombre;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int reglon = dtgvCurso.Rows.Add();
                        dtgvCurso.Rows[reglon].Cells["NCurso"].Value = reader.GetInt32(0);
                        dtgvCurso.Rows[reglon].Cells["NombreCurso"].Value = reader.GetString(1);
                        dtgvCurso.Rows[reglon].Cells["Fecha"].Value = reader.GetDateTime(2).ToString("yyyy-MM-dd");
                        dtgvCurso.Rows[reglon].Cells["Docente"].Value = reader.GetString(3);
                        dtgvCurso.Rows[reglon].Cells["Precio"].Value = reader.GetDecimal(4);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para la carga de la grilla");
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

        private void dtgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvCurso.Columns["Seleccionar"].Index)
            {
                DataGridViewRow filaSeleccionada = dtgvCurso.Rows[e.RowIndex];
                int selectedCourseId = Convert.ToInt32(filaSeleccionada.Cells["NCurso"].Value);
                string nombreCurso = filaSeleccionada.Cells["NombreCurso"].Value.ToString();
                string fecha = filaSeleccionada.Cells["Fecha"].Value.ToString();
                string docente = filaSeleccionada.Cells["Docente"].Value.ToString();
                string precio = filaSeleccionada.Cells["Precio"].Value.ToString();

                string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el NPostu del postulante:", "Asignar Curso", "");
                if (int.TryParse(input, out int nPostu))
                {
                   


                }
                else
                {
                    MessageBox.Show("El NPostu debe ser un número válido", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AsignarCursoAPostulante(int selectedCourseId, int nPostu)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.GetInstancia().Conectar();
                MessageBox.Show($"Curso seleccionado: {selectedCourseId}\nPostulante seleccionado: {nPostu}");
                // Insertar la inscripción en la base de datos
                query = "INSERT INTO curso_postulante (NCurso, NPostu, fecha_inscripcion) VALUES (@NCurso, @NPostu, @fecha_inscripcion)";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@NCurso", selectedCourseId);
                comando.Parameters.AddWithValue("@NPostu", nPostu);
                comando.Parameters.AddWithValue("@fecha_inscripcion", DateTime.Now);

                comando.CommandType = CommandType.Text;
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
                sqlCon.Open();

                int result = comando.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Curso asignado correctamente al postulante", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al asignar el curso", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public string VerificarSiEsAlumno(int nPostu)
        {
            string salida = string.Empty;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().Conectar();
                string query = "SELECT a.Legajo, p.NombreP, p.ApellidoP, p.TDocP, p.DocP " +
                               "FROM alumno a " +
                               "JOIN postulante p ON a.NPostu = p.NPostu " +
                               "WHERE a.NPostu = @NPostu";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@NPostu", nPostu);

                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        salida = $"Legajo: {reader.GetInt32("Legajo")}\n" +
                                 $"Nombre: {reader.GetString("NombreP")}\n" +
                                 $"Apellido: {reader.GetString("ApellidoP")}\n" +
                                 $"Tipo de Documento: {reader.GetString("TDocP")}\n" +
                                 $"Documento: {reader.GetString("DocP")}";
                    }
                }
                else
                {
                    salida = "No es alumno";
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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form atras = new Form2();
            atras.Show();
            this.Close();
        }
    }
}


