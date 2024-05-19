using conexion;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
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
                MessageBox.Show("Ingreso exitoso");

            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

    }
}
