using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class Cliente
    {
        private string dni;
        private string nombreCompleto;
        private string nroCelular;
        private InformacionCliente info;

        public Cliente(string dni, string nombreCompleto, string nroCelular, InformacionCliente info)
        {
            this.Dni = dni;
            this.NombreCompleto = nombreCompleto;
            this.NroCelular = nroCelular;
            this.Info = info;
        }

        public string Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string NroCelular { get => nroCelular; set => nroCelular = value; }
        internal InformacionCliente Info { get => info; set => info = value; }

        public bool esCliente()
        {
            // TODO:
            return false;
        }

        public string getNombre()
        {
            return NombreCompleto;
        }
    }
}
