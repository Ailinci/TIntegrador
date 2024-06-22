
using TIntegrador.Entidades;

namespace TIntegrador.Negocio
{
    internal class BuscarSocioDB
    {
        public string BuscarSocio(string cboTipo, string txtDocumento)
        {
            E_Postulante postu = new E_Postulante();
            postu.TDocP = cboTipo.ToLower();
            postu.DocP = Convert.ToInt32(txtDocumento); // Use Convert.ToInt64 for BIGINT

            // Instanciamos para usar el metodo dentro de postulantes
            Datos.Postulantes postulantes = new Datos.Postulantes();
            string respuesta = postulantes.BuscarPostulante(postu);

            MessageBox.Show("respuesta: " + respuesta); // Añadir esto para depuración
            return respuesta;
        }
    }
}
