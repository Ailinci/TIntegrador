using System.Data;
using TIntegrador.Datos;
using TIntegrador;

namespace pruebaTp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            Usuario usuario = new Usuario();

            dataTable = usuario.Log_Usu(textBox1.Text, textBox2.Text);
            // Validar el usuario

            if (dataTable.Rows.Count > 0)
            {
                // Crear y empezar un nuevo subproceso para abrir Form2
                Form principal = new Form2();
                principal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
