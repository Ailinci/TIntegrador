

namespace TIntegrador.Entidades
{
    public class E_Socio
    {
        public int Legajo { get; set; } // Identificador único del alumno
        public int NPostu { get; set; }
        public string? NombreP { get; set; }
        public string? ApellidoP { get; set; }
        public string? TDocP { get; set; }
        public int DocP { get; set; }

        public E_Socio()
        {
            // Constructor por defecto
        }
    }
}
