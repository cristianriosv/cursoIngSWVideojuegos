using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Ing_SW_Videojuegos2
{
    public class Prestamo
    {
        public Ejemplar ejemplar { get; }
        public Socio socio { get; }
        public DateTime fecha { get; }
        public Prestamo(Ejemplar ejemplar, Socio socio)
        {
            this.ejemplar = ejemplar;
            this.socio = socio;
            this.fecha = DateTime.Today;
        }
    }
}
