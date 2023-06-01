namespace PpaiDsiCu17.Boundaries
{
    partial class PantallaOperador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            subOpcionElegidaBox = new TextBox();
            label4 = new Label();
            opcionElegidaBox = new TextBox();
            label3 = new Label();
            categoriaBox = new TextBox();
            label2 = new Label();
            nombreClienteBox = new TextBox();
            label1 = new Label();
            validacionesBox = new GroupBox();
            registrarButton = new Button();
            cancelarButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(subOpcionElegidaBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(opcionElegidaBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(categoriaBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nombreClienteBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Llamada";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // subOpcionElegidaBox
            // 
            subOpcionElegidaBox.Enabled = false;
            subOpcionElegidaBox.Location = new Point(159, 118);
            subOpcionElegidaBox.Name = "subOpcionElegidaBox";
            subOpcionElegidaBox.ReadOnly = true;
            subOpcionElegidaBox.Size = new Size(193, 23);
            subOpcionElegidaBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 121);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 6;
            label4.Text = "Sub opción Elegida:";
            label4.Click += label4_Click;
            // 
            // opcionElegidaBox
            // 
            opcionElegidaBox.Enabled = false;
            opcionElegidaBox.Location = new Point(115, 86);
            opcionElegidaBox.Name = "opcionElegidaBox";
            opcionElegidaBox.ReadOnly = true;
            opcionElegidaBox.Size = new Size(237, 23);
            opcionElegidaBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 89);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "Opción Elegida:";
            label3.Click += label3_Click;
            // 
            // categoriaBox
            // 
            categoriaBox.Enabled = false;
            categoriaBox.Location = new Point(86, 55);
            categoriaBox.Name = "categoriaBox";
            categoriaBox.ReadOnly = true;
            categoriaBox.Size = new Size(266, 23);
            categoriaBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 58);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Categoría:";
            label2.Click += label2_Click;
            // 
            // nombreClienteBox
            // 
            nombreClienteBox.Enabled = false;
            nombreClienteBox.Location = new Point(138, 26);
            nombreClienteBox.Name = "nombreClienteBox";
            nombreClienteBox.ReadOnly = true;
            nombreClienteBox.Size = new Size(214, 23);
            nombreClienteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Cliente:";
            label1.Click += label1_Click;
            // 
            // validacionesBox
            // 
            validacionesBox.Location = new Point(409, 12);
            validacionesBox.Name = "validacionesBox";
            validacionesBox.Size = new Size(379, 176);
            validacionesBox.TabIndex = 1;
            validacionesBox.TabStop = false;
            validacionesBox.Text = "Validaciones";
            validacionesBox.Enter += groupBox2_Enter;
            // 
            // registrarButton
            // 
            registrarButton.Enabled = false;
            registrarButton.FlatStyle = FlatStyle.Flat;
            registrarButton.ForeColor = Color.Green;
            registrarButton.Location = new Point(662, 188);
            registrarButton.Name = "registrarButton";
            registrarButton.Size = new Size(126, 31);
            registrarButton.TabIndex = 2;
            registrarButton.Text = "Registrar Consulta";
            registrarButton.UseVisualStyleBackColor = true;
            registrarButton.Click += button1_Click_1;
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = SystemColors.Control;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.ForeColor = Color.Red;
            cancelarButton.Location = new Point(535, 188);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(121, 31);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar Llamada";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += cancelarButton_Click_1;
            // 
            // PantallaOperador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 227);
            Controls.Add(cancelarButton);
            Controls.Add(registrarButton);
            Controls.Add(validacionesBox);
            Controls.Add(groupBox1);
            Name = "PantallaOperador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Respuesta";
            Load += PantallaOperador_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox nombreClienteBox;
        private Label label3;
        private TextBox categoriaBox;
        private Label label4;
        private TextBox opcionElegidaBox;
        private TextBox subOpcionElegidaBox;
        private GroupBox validacionesBox;
        private Button registrarButton;
        private Button cancelarButton;
    }
}