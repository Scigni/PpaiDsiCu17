using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class Permiso
    {
        private string descripcion;
        private string nombre;

        public Permiso(string descripcion, string nombre)
        {
            this.Descripcion = descripcion;
            this.Nombre = nombre;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
