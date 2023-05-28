using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class Estado
    {
        private string nombre;

        public Estado(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public bool esFinalizada()
        {
            return nombre.Equals("Finalizada");
        }

        public bool esIniciada()
        {
            return nombre.Equals("Iniciada");
        }

        public string getNombre()
        {
            return nombre;
        }
    }
}
