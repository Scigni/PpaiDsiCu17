using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class CategoriaLlamada
    {
        private string audioMensajeOpciones;
        private string mensajeOpciones;
        private string nombre;
        private string nroOrden;
        private List<OpcionLlamada> opcion;

        public CategoriaLlamada(string audioMensajeOpciones, string mensajeOpciones, string nombre, string nroOrden)
        {
            this.AudioMensajeOpciones = audioMensajeOpciones;
            this.MensajeOpciones = mensajeOpciones;
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
            // Composicion
            this.Opcion = new List<OpcionLlamada>();
        }

        public string AudioMensajeOpciones { get => audioMensajeOpciones; set => audioMensajeOpciones = value; }
        public string MensajeOpciones { get => mensajeOpciones; set => mensajeOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NroOrden { get => nroOrden; set => nroOrden = value; }
        public List<OpcionLlamada> Opcion { get => opcion; set => opcion = value; }

        public string getAudioMensajeOpciones()
        {
            return AudioMensajeOpciones;
        }
    }
}
