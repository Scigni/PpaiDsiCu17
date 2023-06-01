using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class OpcionValidacion
    {
        private string correcta;
        private string descripcion;

        public OpcionValidacion(string correcta)
        {
            this.Correcta = correcta;
        }

        public string Correcta { get => correcta; set => correcta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool esCorrecta(string opcionAValidar)
        {
            return Correcta.Equals(opcionAValidar);
        }

        public string getDescripcion()
        {
            return Descripcion;
        }
    }
}
