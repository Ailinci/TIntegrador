
using System.Drawing.Printing;
using static TIntegrador.frmPagar;

namespace TIntegrador
{
    public partial class frmFactura : Form
    {
        public frmFactura(TicketData ticketData)
        {
            InitializeComponent();
            lblAlumno.Text = ticketData.Alumno;
            lblCurso.Text = ticketData.Curso;
            lblDia.Text = ticketData.Fecha.ToString("yyyy-MM-dd");
            lblValor.Text = ticketData.Monto.ToString("F2");
            lblFPago.Text = ticketData.FormaPago;
            lblDfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true;
            MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form principal = new Form2();
            principal.Show();
            this.Close();
        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form principal = new Form2();
            principal.Show();
            this.Close();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
