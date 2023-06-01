using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class OpcionLlamada
    {
        private string audioMensajeSubopciones;
        private string mensajeSubopciones;
        private string nombre;
        private string nroOrden;
        private List<SubOpcionLlamada> subOpcionLlamada;
        private List<Validacion> validacionesRequeridas;

        public OpcionLlamada(string audioMensajeSubopciones, string mensajeSubopciones, string nombre, string nroOrden, List<SubOpcionLlamada> subOpcionLlamada)
        {
            this.audioMensajeSubopciones = audioMensajeSubopciones;
            this.mensajeSubopciones = mensajeSubopciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.subOpcionLlamada = subOpcionLlamada;
        }

        public OpcionLlamada(string audioMensajeSubopciones, string mensajeSubopciones, string nombre, string nroOrden, List<SubOpcionLlamada> subOpcionLlamada, List<Validacion> validacionesRequeridas)
        {
            this.AudioMensajeSubopciones = audioMensajeSubopciones;
            this.MensajeSubopciones = mensajeSubopciones;
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
            this.SubOpcionLlamada = new List<SubOpcionLlamada>();
            this.ValidacionesRequeridas = validacionesRequeridas;
        }

        public string AudioMensajeSubopciones { get => audioMensajeSubopciones; set => audioMensajeSubopciones = value; }
        public string MensajeSubopciones { get => mensajeSubopciones; set => mensajeSubopciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NroOrden { get => nroOrden; set => nroOrden = value; }
        public List<SubOpcionLlamada> SubOpcionLlamada { get => subOpcionLlamada; set => subOpcionLlamada = value; }
        public List<Validacion> ValidacionesRequeridas { get => validacionesRequeridas; set => validacionesRequeridas = value; }

        public string getAudioMensajeSubopciones()
        {
            return AudioMensajeSubopciones;
        }

        public void getDescripcionConSubOpcion()
        {
            // TODO: 
        }
    }
}
