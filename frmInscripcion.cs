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
    }
}
