using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIntegrador.Datos;

namespace TIntegrador
{
    public partial class frmPagar : Form
    {
        public frmFactura doc = new frmFactura();
        public frmPagar()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form principal = new Form2();
            principal.Show();
            this.Close();
        }
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();
            this.Hide();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.GetInstancia().Conectar();
                /*
                --------------------------------------------------------
                -------------------------
                * Consulta simple que proyecta los datos necesarios
                * para rellenar el documento
                * En este caso se trata del comprobante de pago del
                curso
                *
                --------------------------------------------------------
                ------------------------------------ */
                query = ("select idinscri, nombre, concat(nombrep, '', apellidop), precio,e.fecha " + "from inscripcion i inner join edicion e oni.idEdicion = e.idEdicion" + " inner join curso c on c.ncurso = e.ncurso innerjoin alumno a on a.legajo = i.legajo" + " inner join postulante p on p.NPostu = a.Npostuwhere idinscri = " + txtNro.Text); // <<<------ usamos el dato ingresado por el usuario
                MySqlCommand comando = new MySqlCommand(query,
                sqlCon);
                // usamos la consulta y la conexion.-
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader; // El DataReader almacena TODAS las filas.-
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // En este caso sabemos que si tiene datos es UNA SOLA FILA
                    doc.numero_f = Convert.ToInt32(reader.GetString
                    (0));
                    doc.curso_f = reader.GetString(1);
                    doc.alumno_f = reader.GetString(2);
                    doc.monto_f = (float)Convert.ToDouble
                    (reader.GetString(3));
                    doc.fecha_f = (DateTime)Convert.ToDateTime
                    (reader.GetString(4));
                    if (optEfvo.Checked == true) // Evaluamos que opcion es la seleccionada
                    {
                        doc.forma_f = "Efectivo";
                        /* ---------------------------------
                        * Pago en efvo se descuenta 10%
                        * --------------------------------- */
                        doc.monto_f = (float)(doc.monto_f * 0.90);
                    }
                    else
                    {
                        doc.forma_f = "Tarjeta";
                    }
                    btnComprobante.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Número de inscripcion inexistente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Form principal = new Form2();
            principal.Show();
            this.Close();
        }
    }
}
