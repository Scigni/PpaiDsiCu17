using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class Perfil
    {
        private string descripcion;
        private string nombre;
        private List<Permiso> permisos;

        public Perfil(string descripcion, string nombre, List<Permiso> permisos)
        {
            this.Descripcion = descripcion;
            this.Nombre = nombre;
            this.Permisos = permisos;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Permiso> Permisos { get => permisos; set => permisos = value; }
    }
}
