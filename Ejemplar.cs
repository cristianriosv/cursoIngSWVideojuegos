using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Ing_SW_Videojuegos2
{
    public class Ejemplar
    {
        public Libro libro { get; }
        public string edicion { get; }
        public string ubicacion { get; }

        public Ejemplar(Libro libro, string edicion, string ubicacion)
        {
            this.libro = libro;
            this.edicion = edicion;
            this.ubicacion = ubicacion;
        }
    }
}
