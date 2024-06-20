using pruebaTp;

namespace TIntegrador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

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
    }
}
