
using TIntegrador.Entidades;

namespace TIntegrador
{
    public partial class frmPagar : Form
    {
        public frmPagar(int legajo, string TDocP, int DocP)
        {
            InitializeComponent();
            txtNro.Text = legajo.ToString();
            cboTipo.Text = TDocP;
            txtDocumento.Text = DocP.ToString();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form principal = new Form2();
            principal.Show();
            this.Close();
        }
        private void btnComprobante_Click(object sender, EventArgs e)
        {
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Socio socio = new E_Socio();
                socio.DocP = Convert.ToInt32(txtDocumento.Text);
                socio.TDocP = cboTipo.Text;

                Datos.Socio socios = new Datos.Socio();
                string respuesta = socios.GenerarIdRegistro(socio);
                var ticketData = ParseTicketData(respuesta);

                frmFactura factura = new frmFactura(ticketData);
                factura.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TicketData ParseTicketData(string response)
        {
            var lines = response.Split('\n');
            return new TicketData
            {
                Alumno = lines[0].Split(':')[1].Trim(),
                Curso = "Costo por asociación",
                Fecha = DateTime.Now,
                Monto = float.Parse(lines[2].Split(':')[1].Trim()),
                FormaPago = btnTarjeta.Checked ? "Tarjeta" : "Efectivo"
            };
        }

        // Class to hold ticket data
        public class TicketData
        {
            public string Alumno { get; set; }
            public string Curso { get; set; }
            public DateTime Fecha { get; set; }
            public float Monto { get; set; }
            public string FormaPago { get; set; }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Form principal = new Form2();
            principal.Show();
            this.Close();
        }
    }
}
