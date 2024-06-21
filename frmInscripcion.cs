using TIntegrador.Entidades;

namespace TIntegrador
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }
        /* -------------------------------
        * permite retornar al formulario PRINCIPAL
        * ------------------------------------------------------ */
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 principal = new Form2();
            principal.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPostular_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
            txtDocumento.Text == "" || cboTipo.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Postulante postu = new E_Postulante();
                postu.NombreP = txtNombre.Text;
                postu.ApellidoP = txtApellido.Text;
                postu.DocP = Convert.ToInt32(txtDocumento.Text);
                postu.TDocP = cboTipo.Text;

                // instanciamos para usar el metodo dentro de postulantes
                Datos.Postulantes postulantes = new Datos.Postulantes();
                respuesta = postulantes.Nuevo_Postu(postu);
                bool esnumero = int.TryParse(respuesta, out int codigo);

                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    }
                }
            }

        }
        /* ===================================================
         Limpiamos los objetos para un nuevo ingreso
        * ================================================ */

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboTipo.Text = "";
            txtNombre.Focus();

        }

        private void btnVolver_Click_2(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Close();

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHacerSocio_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
                txtDocumento.Text == "" || cboTipo.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos requeridos (*) ",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                E_Socio socio = new E_Socio();
                socio.NombreP = txtNombre.Text;
                socio.ApellidoP = txtApellido.Text;
                socio.DocP = Convert.ToInt32(txtDocumento.Text);
                socio.TDocP = cboTipo.Text;

                Datos.Socio socios = new Datos.Socio();
                string respuesta = socios.Nuevo_Socio(socio);
                bool esnumero = int.TryParse(respuesta, out int codigo);

                MessageBox.Show("entra a crear", "AVISO DEL SISTEMA");
                MessageBox.Show(respuesta, "AVISO DEL SISTEMA");

                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("ALUMNO YA EXISTE", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se convirtió en socio con éxito con el código Nro " + respuesta,
                            "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        private void btnBuscarPos_Click(object sender, EventArgs e)
        {

                E_Postulante postu = new E_Postulante();
                postu.TDocP = cboTipo.Text.ToLower();
                postu.DocP = Convert.ToInt32(txtDocumento.Text); // Use Convert.ToInt64 for BIGINT

                // Instanciamos para usar el metodo dentro de postulantes
                Datos.Postulantes postulantes = new Datos.Postulantes();
                string respuesta = postulantes.BuscarPostulante(postu);

                MessageBox.Show("respuesta: " + respuesta); // Añadir esto para depuración

                if (respuesta == "No data found")
                {
                    DialogResult resultado = MessageBox.Show("El postulante no existe. ¿Desea crear la ficha?",
                                             "AVISO DEL SISTEMA",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Information);

                    // Verificar la respuesta del usuario
                    if (resultado == DialogResult.Yes)
                    {
                        btnHacerSocio_Click(sender, e);
                    }
     
          
                }
                else if (respuesta.Contains("Error"))
                {
                    MessageBox.Show("Ocurrió un error: " + respuesta, "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Form pagar = new frmPagar();
                    pagar.Show();
                    this.Close();
                }
        }
    }
}
