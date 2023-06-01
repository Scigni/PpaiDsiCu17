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
        private List<Validacion> validacionRequeridas;

        public SubOpcionLlamada(string nombre, string nroOrden, List<Validacion> validacionRequeridas)
        {
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
            this.ValidacionRequeridas = validacionRequeridas;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string NroOrden { get => nroOrden; set => nroOrden = value; }
        public List<Validacion> ValidacionRequeridas { get => validacionRequeridas; set => validacionRequeridas = value; }

        public bool esNro(string nro)
        {
            return NroOrden.Equals(nro);
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void addValidacion(Validacion validacion)
        {
            ValidacionRequeridas.Add(validacion);
        }

        public List<Validacion> getValidaciones()
        {
            return validacionRequeridas;
        }
    }
}
