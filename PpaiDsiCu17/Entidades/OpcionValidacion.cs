using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class OpcionValidacion
    {
        private bool correcta;
        private string descripcion;

        public OpcionValidacion(bool correcta, string descripcion)
        {
            this.Correcta = correcta;
            this.Descripcion = descripcion;
        }

        public bool Correcta { get => correcta; set => correcta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool esCorrecta()
        {
            return Correcta;
        }

        public string getDescripcion()
        {
            return Descripcion;
        }
    }
}
