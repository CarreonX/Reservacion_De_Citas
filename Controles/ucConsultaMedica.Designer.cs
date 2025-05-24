namespace Controles
{
    partial class ucConsultaMedica
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtIdConsulta = new TextBox();
            txtPaciente = new TextBox();
            txtDentista = new TextBox();
            txtProximaCita = new TextBox();
            txtDiagnostico = new TextBox();
            txtMotivoConsulta = new TextBox();
            txtIDReceta = new TextBox();
            dtpFechaConsulta = new DateTimePicker();
            txtDuracion = new TextBox();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 37);
            label1.Name = "label1";
            label1.Size = new Size(234, 38);
            label1.TabIndex = 24;
            label1.Text = "Consulta Médica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 105);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 25;
            label2.Text = "ID Consulta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 289);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 26;
            label3.Text = "Diagnóstico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 237);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 27;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 178);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 28;
            label5.Text = "Dentista:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(448, 105);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 29;
            label6.Text = "Paciente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(516, 237);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 30;
            label7.Text = "Próxima cita:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 583);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 31;
            label8.Text = "ID Receta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 442);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 32;
            label9.Text = "Motivo de Consulta:";
            // 
            // txtIdConsulta
            // 
            txtIdConsulta.Location = new Point(163, 98);
            txtIdConsulta.Name = "txtIdConsulta";
            txtIdConsulta.ReadOnly = true;
            txtIdConsulta.Size = new Size(247, 27);
            txtIdConsulta.TabIndex = 33;
            // 
            // txtPaciente
            // 
            txtPaciente.Location = new Point(516, 98);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(435, 27);
            txtPaciente.TabIndex = 34;
            // 
            // txtDentista
            // 
            txtDentista.Location = new Point(163, 178);
            txtDentista.Name = "txtDentista";
            txtDentista.ScrollBars = ScrollBars.Vertical;
            txtDentista.Size = new Size(407, 27);
            txtDentista.TabIndex = 35;
            // 
            // txtProximaCita
            // 
            txtProximaCita.Location = new Point(616, 232);
            txtProximaCita.Name = "txtProximaCita";
            txtProximaCita.Size = new Size(335, 27);
            txtProximaCita.TabIndex = 36;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(163, 289);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.ScrollBars = ScrollBars.Vertical;
            txtDiagnostico.Size = new Size(788, 138);
            txtDiagnostico.TabIndex = 37;
            // 
            // txtMotivoConsulta
            // 
            txtMotivoConsulta.Location = new Point(163, 442);
            txtMotivoConsulta.Multiline = true;
            txtMotivoConsulta.Name = "txtMotivoConsulta";
            txtMotivoConsulta.ScrollBars = ScrollBars.Vertical;
            txtMotivoConsulta.Size = new Size(788, 121);
            txtMotivoConsulta.TabIndex = 38;
            // 
            // txtIDReceta
            // 
            txtIDReceta.Location = new Point(163, 580);
            txtIDReceta.Name = "txtIDReceta";
            txtIDReceta.Size = new Size(308, 27);
            txtIDReceta.TabIndex = 39;
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.Location = new Point(163, 232);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.Size = new Size(308, 27);
            dtpFechaConsulta.TabIndex = 40;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(704, 178);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.ScrollBars = ScrollBars.Vertical;
            txtDuracion.Size = new Size(186, 27);
            txtDuracion.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(627, 178);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 41;
            label10.Text = "Duración:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(890, 181);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 43;
            label11.Text = "minutos.";
            // 
            // ucConsultaMedica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(label11);
            Controls.Add(txtDuracion);
            Controls.Add(label10);
            Controls.Add(dtpFechaConsulta);
            Controls.Add(txtIDReceta);
            Controls.Add(txtMotivoConsulta);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtProximaCita);
            Controls.Add(txtDentista);
            Controls.Add(txtPaciente);
            Controls.Add(txtIdConsulta);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucConsultaMedica";
            Size = new Size(1007, 638);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        public TextBox txtIdConsulta;
        public TextBox txtPaciente;
        public TextBox txtDentista;
        public TextBox txtProximaCita;
        public TextBox txtDiagnostico;
        public TextBox txtMotivoConsulta;
        public TextBox txtIDReceta;
        public DateTimePicker dtpFechaConsulta;
        public TextBox txtDuracion;
        private Label label10;
        private Label label11;
    }
}
