using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Ing_SW_Videojuegos2
{
    public class Socio
    {
        public string nombre { get; }
        public virtual double cuota { get; }
        public string apellido { get; }
        public string id { get; }
        public List<Ejemplar> listaRetirados { get; }
        public virtual int max { get; }
        public Socio(string nombre, string apellido, string id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
            listaRetirados = new List<Ejemplar>();
            cuota = 0;
            max = 3;
        }
        public bool cupoDisponible()
        {
            return listaRetirados.Count < max;
        }
        public void agregarEjemplar(Ejemplar newEjemplar)
        {
            if (cupoDisponible())
            {
                listaRetirados.Add(newEjemplar);
            }
        }
        public Ejemplar devolverEjemplar(int pos)
        {
            if(pos < listaRetirados.Count)
            {
                Ejemplar removeEjemplar = listaRetirados[pos];
                listaRetirados.RemoveAt(pos);
                return removeEjemplar;
            }
            return null;
        }
    }
}
