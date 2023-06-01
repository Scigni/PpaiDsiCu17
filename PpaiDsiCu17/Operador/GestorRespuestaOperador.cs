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

            this.estadosPosibles = new Dictionary<string, Estado>()
            {
                { "iniciada", estadoIniciada },
                { "en curso", estadoEnCurso },
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
            string categoriaSeleccionada = categoriaElegida.Nombre;
            string opcionSeleccionada = llamadaEntrante.OpcionSeleccionada.Nombre;
            string subOpcionSeleccionada = llamadaEntrante.SubOpcionSellecionada?.Nombre;
            Console.WriteLine($"es {subOpcionSeleccionada != null}");
            List<Validacion> validaciones = subOpcionSeleccionada != null ?
                llamadaEntrante.SubOpcionSellecionada.ValidacionRequeridas : llamadaEntrante.OpcionSeleccionada.ValidacionesRequeridas;
            Console.WriteLine($"test a {validaciones.Count}");
            pantalla.habilitarPantalla();
            pantalla.mostrarDatosConsulta(nombreCliente, categoriaSeleccionada, opcionSeleccionada, subOpcionSeleccionada);
            pantalla.pedirDatosAValidar(validaciones);
        }

        public bool tomarRespuesta(string datoAValidar, string tipoInformacion)
        {
            bool resultado = false;
            List<InformacionCliente> informacion = this.llamadaEntrante.Cliente.Info;
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

        public void tomarDescripcionOperador()
        {

        }

    }
}
