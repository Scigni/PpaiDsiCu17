using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private TimeSpan duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private List<CambioEstado> cambioEstado;
        private Accion accionRequerida;
        private Cliente cliente;
        private Usuario operador;
        private Usuario auditor;
        private SubOpcionLlamada subOpcionSeleccionada;
        private OpcionLlamada opcionSeleccionada;

        public Llamada(Cliente cliente, OpcionLlamada opcionSeleccionada, SubOpcionLlamada subOpcionSeleccionada)
        {
            this.cliente = cliente;
            this.opcionSeleccionada = opcionSeleccionada;
            this.subOpcionSeleccionada = subOpcionSeleccionada;
            this.cambioEstado = new List<CambioEstado>();
        }

        public Llamada(string descripcionOperador, string detalleAccionRequerida, TimeSpan duracion, bool encuestaEnviada, string observacionAuditor, List<CambioEstado> cambioEstado, Accion accionRequerida, Cliente cliente, Usuario operador, Usuario auditor, SubOpcionLlamada subOpcionSellecionada, OpcionLlamada opcionSeleccionada)
        {
            this.DescripcionOperador = descripcionOperador;
            this.DetalleAccionRequerida = detalleAccionRequerida;
            this.Duracion = duracion;
            this.EncuestaEnviada = encuestaEnviada;
            this.ObservacionAuditor = observacionAuditor;
            this.CambioEstado = cambioEstado;
            this.AccionRequerida = accionRequerida;
            this.Cliente = cliente;
            this.Operador = operador;
            this.Auditor = auditor;
            this.SubOpcionSellecionada = subOpcionSellecionada;
            this.OpcionSeleccionada = opcionSeleccionada;
        }

        public string DescripcionOperador { get => descripcionOperador; set => descripcionOperador = value; }
        public string DetalleAccionRequerida { get => detalleAccionRequerida; set => detalleAccionRequerida = value; }
        public TimeSpan Duracion { get => duracion; set => duracion = value; }
        public bool EncuestaEnviada { get => encuestaEnviada; set => encuestaEnviada = value; }
        public string ObservacionAuditor { get => observacionAuditor; set => observacionAuditor = value; }
        public List<CambioEstado> CambioEstado { get => cambioEstado; set => cambioEstado = value; }
        public Accion AccionRequerida { get => accionRequerida; set => accionRequerida = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Usuario Operador { get => operador; set => operador = value; }
        public Usuario Auditor { get => auditor; set => auditor = value; }
        public SubOpcionLlamada SubOpcionSellecionada { get => subOpcionSeleccionada; set => subOpcionSeleccionada = value; }
        public OpcionLlamada OpcionSeleccionada { get => opcionSeleccionada; set => opcionSeleccionada = value; }

        public TimeSpan getDuracion()
        {
            return Duracion;
        }

        public void setDuracion(TimeSpan duracion)
        {
            this.Duracion = duracion;
        }

        public void setEstadoActual(Estado estado)
        {
            CambioEstado.Add(new CambioEstado(estado));
        }

        public string getNombreClienteDeLlamada()
        {
            return Cliente.getNombre();
        }

        public void getRespuestas()
        {
            // TODO:
        }

        public bool esDePeriodo()
        {
            // TODO:
            return false;
        }

        public TimeSpan calcularDuracion()
        {
            // TODO: 
            return TimeSpan.Zero;
        }
    }

}
