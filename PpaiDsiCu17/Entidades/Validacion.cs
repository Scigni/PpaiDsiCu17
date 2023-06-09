﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class Validacion
    {
        private string audioMensajeValidacion;
        private string nombre;
        private string nroOrder;
        private List<OpcionValidacion> opcionesValidacion;
        private TipoInformacion tipo;

        public Validacion(string audioMensajeValidacion, string nombre, string nroOrder, TipoInformacion tipo)
        {
            this.AudioMensajeValidacion = audioMensajeValidacion;
            this.Nombre = nombre;
            this.NroOrder = nroOrder;
            this.OpcionesValidacion = new List<OpcionValidacion>();
            this.Tipo = tipo;
        }

        public string AudioMensajeValidacion { get => audioMensajeValidacion; set => audioMensajeValidacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NroOrder { get => nroOrder; set => nroOrder = value; }
        public List<OpcionValidacion> OpcionesValidacion { get => opcionesValidacion; set => opcionesValidacion = value; }
        public TipoInformacion Tipo { get => tipo; set => tipo = value; }

        public string getAudioMensajeValidacion()
        {
            return AudioMensajeValidacion;
        }

        public void getMensajeValidacion()
        {
            // TODO: Revisar diferencia entre Audio / Mensaje
        }
    }
}
