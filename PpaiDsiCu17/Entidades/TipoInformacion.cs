using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class TipoInformacion
    {
        private string descripcion;

        public TipoInformacion(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public string getDescripcion()
        {
            return Descripcion;
        }

        public void setDescripcion(string descripcion)
        {
            this.Descripcion = descripcion;
        }
    }
}
