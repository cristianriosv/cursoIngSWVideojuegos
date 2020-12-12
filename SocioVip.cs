using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Ing_SW_Videojuegos2
{
    public class SocioVip : Socio
    {

        public override double cuota { get; }
        public override int max { get; }

        public SocioVip(string nombre, string apellido, string id) : base(nombre, apellido, id)
        {
            cuota = 100;
            max = 15;
        }
    }
}
