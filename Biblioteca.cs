using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Ing_SW_Videojuegos2
{
    public class Biblioteca
    {
        public List<Libro> libros { get; }
        public List<Socio> socios { get; }
        public List<Prestamo> prestamos { get; }

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.socios = new List<Socio>();
            this.prestamos = new List<Prestamo>();
        }
        public void agregarLibro(Libro libro)
        {
            libros.Add(libro);
        }
        public void agregarSocio(Socio socio)
        {
            socios.Add(socio);
        }
        public void agregarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }
    }
}
