using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class InformacionCliente
    {
        private string datoAValidar;
        private Validacion validacion;
        private OpcionValidacion opcionCorrecta;
        private TipoInformacion tipo;

        public InformacionCliente(string datoAValidar, Validacion validacion, OpcionValidacion opcionCorrecta, TipoInformacion tipo)
        {
            this.DatoAValidar = datoAValidar;
            this.Validacion = validacion;
            this.OpcionCorrecta = opcionCorrecta;
            this.Tipo = tipo;
        }

        public string DatoAValidar { get => datoAValidar; set => datoAValidar = value; }
        internal Validacion Validacion { get => validacion; set => validacion = value; }
        internal OpcionValidacion OpcionCorrecta { get => opcionCorrecta; set => opcionCorrecta = value; }
        internal TipoInformacion Tipo { get => tipo; set => tipo = value; }

        public bool esInformacionCorrecta()
        {
            // TODO: 
            return false;
        }

        public bool esValidacion()
        {
            // TODO:
            return false;
        }
    }
}
