using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PpaiDsiCu17.Entidades
{
    public class SubOpcionLlamada
    {
        private string nombre;
        private string nroOrden;

        public SubOpcionLlamada(string nombre, string nroOrden)
        {
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string NroOrden { get => nroOrden; set => nroOrden = value; }

        public bool esNro(string nro)
        {
            return NroOrden.Equals(nro);
        }

        public string getNombre()
        {
            return Nombre;
        }
    }
}
