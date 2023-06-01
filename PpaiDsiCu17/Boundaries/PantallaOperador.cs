using PpaiDsiCu17.Entidades;
using PpaiDsiCu17.Operador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpaiDsiCu17.Boundaries
{
    public partial class PantallaOperador : Form
    {
        private GestorRespuestaOperador gestor;

        private List<bool> validacionesAceptadas = new List<bool>();
        private List<TabPage> tabPages = new List<TabPage>();
        public PantallaOperador()
        {
            AllocConsole();
            TipoInformacion tipoInfo1 = new TipoInformacion("fecha de nacimiento");
            OpcionValidacion opcionCorrecta1 = new OpcionValidacion("01/01/2000");

            TipoInformacion tipoInfo2 = new TipoInformacion("cantidad de hijos");
            OpcionValidacion opcionCorrecta2 = new OpcionValidacion("0");

            Validacion validacion1 = new Validacion("", "fecha de nacimiento", tipoInfo1);
            validacion1.addOpcionValidacion(opcionCorrecta1);
            Validacion validacion2 = new Validacion("", "cantidad de hijos", tipoInfo2);
            validacion2.addOpcionValidacion(opcionCorrecta2);

            InformacionCliente info1 = new InformacionCliente(validacion1, opcionCorrecta1, tipoInfo1);
            InformacionCliente info2 = new InformacionCliente(validacion2, opcionCorrecta2, tipoInfo2);

            Cliente cliente = new Cliente("123456789", "testNombre testApellido", "123456789", new List<InformacionCliente> { info1, info2 });

            SubOpcionLlamada subOpcionSeleccionada1 = new SubOpcionLlamada("cuenta con los datos de la tarjeta", "1", new List<Validacion> { validacion1, validacion2 });
            SubOpcionLlamada subOpcionSeleccionada2 = new SubOpcionLlamada("no cuenta con los datos de la tarjeta", "2", new List<Validacion> { });
            SubOpcionLlamada subOpcionSeleccionada3 = new SubOpcionLlamada("comunicarse con un responsable de atención al cliente", "3", new List<Validacion> { });

            OpcionLlamada opcionSeleccionada = new OpcionLlamada("informar un robo y solicitar nueva tarjeta", "", "robo de tarjeta", "1",
                new List<SubOpcionLlamada> { subOpcionSeleccionada1, subOpcionSeleccionada2, subOpcionSeleccionada3 });

            CategoriaLlamada categoriaLlamada = new CategoriaLlamada("", "", "informar un robo", "1");
            categoriaLlamada.addOpcion(opcionSeleccionada);

            Llamada llamada = new Llamada(cliente, opcionSeleccionada, subOpcionSeleccionada1);
            llamada.CambioEstado = new List<CambioEstado> { new CambioEstado(new Estado("Iniciada")) };

            this.gestor = new GestorRespuestaOperador(llamada, categoriaLlamada, this);

            gestor.comunicarOperador();
        }

        public void habilitarPantalla()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void mostrarDatosConsulta(string nombreCliente, string categoriaSeleccionada, string opcionSeleccionada, string subOpcionSeleccionada)
        {
            nombreClienteBox.Text = nombreCliente;
            categoriaBox.Text = categoriaSeleccionada;
            opcionElegidaBox.Text = opcionSeleccionada;
            subOpcionElegidaBox.Text = subOpcionSeleccionada != null ? subOpcionSeleccionada : null;
        }

        public void pedirDatosAValidar(List<Validacion> validaciones)
        {
            Console.WriteLine("test", validaciones.Count);
            TabControl tabControl = new TabControl();
            tabControl.Location = new Point(6, 22);
            tabControl.Size = new Size(367, 148);

            for (int i = 0; i < validaciones.Count; i++)
            {
                validacionesAceptadas.Add(false);
                Console.WriteLine(i);
                TabPage tabPage = new TabPage($"Validacion {i + 1}");
                Console.WriteLine(i);
                Label label = new Label();
                label.Text = $"Ingrese la {validaciones[i].Nombre}:";
                label.Location = new Point(6, 9);
                label.AutoSize = true;

                TextBox textBox = new TextBox();
                textBox.Location = new Point(6, 27);
                textBox.Size = new Size(347, 23);

                Button button = new Button();
                button.Text = "Validar";
                button.Location = new Point(6, 60);
                button.AutoSize = true;
                string descripcion = validaciones[i].Tipo.Descripcion;
                int num = i;
                button.Click += (sender, e) => mostrarPopOutValidacion(sender, e, textBox.Text, descripcion, num);

                tabPage.Controls.Add(label);
                tabPage.Controls.Add(textBox);
                tabPage.Controls.Add(button);

                tabControl.TabPages.Add(tabPage);
                tabPages.Add(tabPage);
            }
            this.Controls.Add(tabControl);
            validacionesBox.Controls.Add(tabControl);
        }

        private void mostrarPopOutValidacion(object sender, EventArgs e, string respuestaValidacion, string tipoDescripcion, int numTab)
        {
            if (!gestor.tomarRespuesta(respuestaValidacion, tipoDescripcion))
            {
                MessageBox.Show("El dato ingresado no es correcto", "Message", MessageBoxButtons.OK);
                return;
            }
            validacionAceptada(numTab);
            Console.WriteLine(isAllValidacionesAceptadas());
            if (!isAllValidacionesAceptadas())
            {
                registrarButton.Enabled = true;
            }

            ((Control)tabPages[numTab]).Enabled = false;
        }

        private void validacionAceptada(int numtab)
        {
            TextBox textBox = new TextBox();
            textBox.Text = "ACEPTADA";
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Color.LightGreen;
            textBox.ForeColor = Color.White;
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
            textBox.Location = new Point(140, 60);

            tabPages[numtab].Controls.Add(textBox);
            validacionesAceptadas[numtab] = true;
        }

        private bool isAllValidacionesAceptadas()
        {
            return validacionesAceptadas.Any(a => a == false);
        }

        private void PantallaOperador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pedirDescripcionAccion();
        }

        private void pedirDescripcionAccion()
        {
            Form form = new Form();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void solicitarConfirmacion()
        {

        }
        private void cancelarButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

    }
}
