using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PpaiDsiCu17.Boundaries;
using PpaiDsiCu17.Entidades;   

namespace PpaiDsiCu17.Operador
{
    public class GestorRespuestaOperador
    {
        private Dictionary<string, Estado> estadosPosibles;
        private Llamada llamadaEntrante;
        private CategoriaLlamada categoriaElegida;
        
        private PantallaOperador pantalla;

        public GestorRespuestaOperador(Llamada llamadaEntrante, CategoriaLlamada categoriaElegida, PantallaOperador pantalla)
        {
            Estado estadoIniciada = new Estado("Iniciada");
            Estado estadoEnCurso = new Estado("En Curso");
            Estado estadoFinalizada = new Estado("Finalizada");
            Estado estadoCancelada = new Estado("Cancelada");

            this.estadosPosibles = new Dictionary<string, Estado>()
            {
                { "iniciada", estadoIniciada },
                { "en curso", estadoEnCurso },
                { "cancelada", estadoCancelada },
                { "finalizada", estadoFinalizada }
            };
            this.llamadaEntrante = llamadaEntrante;
            this.categoriaElegida = categoriaElegida;
            this.pantalla = pantalla;
        }

        public void comunicarOperador()
        {
            llamadaEntrante.setEstadoActual(estadosPosibles["en curso"]);
            string nombreCliente = llamadaEntrante.getNombreClienteDeLlamada();
            string categoriaSeleccionada = categoriaElegida.getNombre();
            string opcionSeleccionada = llamadaEntrante.getNombreOpcion();
            string subOpcionSeleccionada = llamadaEntrante.getNombreSubOpcion();
            List<Validacion> validaciones = llamadaEntrante.getValidacions();

            Console.WriteLine($"test a {validaciones.Count}");
            pantalla.habilitarPantalla();
            pantalla.mostrarDatosConsulta(nombreCliente, categoriaSeleccionada, opcionSeleccionada, subOpcionSeleccionada);
            pantalla.pedirDatosAValidar(validaciones);
        }

        public bool tomarRespuesta(string datoAValidar, string tipoInformacion)
        {
            bool resultado = false;
            List<InformacionCliente> informacion = llamadaEntrante.getCliente().getInformacionCliente();
            foreach (InformacionCliente i in informacion)
            {
                Console.WriteLine($"ES : {i.Tipo.Descripcion.Equals(tipoInformacion)}");
                if (i.Tipo.Descripcion.Equals(tipoInformacion))
                {
                    resultado = i.OpcionCorrecta.esCorrecta(datoAValidar);
                }
                Console.WriteLine($"RESULTADO ES: {resultado}");
            }
            return resultado;
        }

        public void tomarDescripcionAccion(string descripcionOperador, string accion)
        {
            llamadaEntrante.setDescripcionOperador(descripcionOperador);
            llamadaEntrante.setAccion(new Accion(accion));

            pantalla.solicitarConfirmacion();
        }

        public void llamarCU28()
        {
            // a
            registrarLlamada();
        }

        public void registrarLlamada()
        {
            llamadaEntrante.setEstadoActual(estadosPosibles["finalizada"]);
            TimeSpan duracion = llamadaEntrante.calcularDuracion();
            llamadaEntrante.setDuracion(duracion);
        }
    }
}
