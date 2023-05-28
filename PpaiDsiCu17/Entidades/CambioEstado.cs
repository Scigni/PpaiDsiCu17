using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class CambioEstado
    {
        private DateTime fechaHoraIniciio;
        private Estado estado;

        public CambioEstado(DateTime fechaHoraIniciio, Estado estado)
        {
            this.FechaHoraIniciio = fechaHoraIniciio;
            this.Estado = estado;
        }

        public DateTime FechaHoraIniciio { get => fechaHoraIniciio; set => fechaHoraIniciio = value; }
        public Estado Estado { get => estado; set => estado = value; }

        public DateTime getFechaHoraInicio()
        {
            return fechaHoraIniciio;
        }

        public string getNombreEstado()
        {
            return estado.getNombre();
        }
    }
}
