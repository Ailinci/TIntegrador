
using pruebaTp;

namespace TIntegrador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        internal string? rol;
        internal string? usuario;

        private void button1_Click(object sender, EventArgs e)

        {
            Form inscribir = new frmInscripcion();
            inscribir.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form principal = new Form1();
            principal.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form asignar = new frmAsignar();
            asignar.Show();
            this.Hide();
        }

        private void btnListarSocios_Click(object sender, EventArgs e)
        {
            Form listarSocios = new frmListarSocios();
            listarSocios.Show();
            this.Close();
        }
    }
}
