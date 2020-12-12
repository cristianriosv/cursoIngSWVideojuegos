using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Ing_SW_Videojuegos2
{
    public class Libro
    {
        public string nombre { get; }
        public string isbn { get; }
        public string autor { get; }
        public List<Ejemplar> lista { get; }

        public Libro(string nombre, string isbn, string autor)
        {
            this.nombre = nombre;
            this.isbn = isbn;
            this.autor = autor;
            this.lista = new List<Ejemplar>();
        }

        public void agregarEjemplar(string edicion, string ubicacion)
        {
            Ejemplar newEjemplar = new Ejemplar(this, edicion, ubicacion);
            lista.Add(newEjemplar);
        }
        public bool ejemplaresDisponibles()
        {
            return lista.Count > 0;
        }
        public Ejemplar prestarEjemplar(int pos)
        {
            if(pos < lista.Count)
            {
                Ejemplar removeEjemplar = lista[pos];
                lista.RemoveAt(pos);
                return removeEjemplar;
            }
            return null;
        }
    }
}
