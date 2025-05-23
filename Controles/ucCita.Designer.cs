namespace Controles
{
    partial class ucCita
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
            txtEstadoCita = new TextBox();
            label4 = new Label();
            txtFechaSolicitud = new TextBox();
            label3 = new Label();
            txtFechaCita = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtDuracion = new TextBox();
            label5 = new Label();
            txtHora = new TextBox();
            label6 = new Label();
            txtodontologo = new TextBox();
            label7 = new Label();
            txtPaciente = new TextBox();
            label8 = new Label();
            txtMotivo = new TextBox();
            label9 = new Label();
            txtIdCita = new TextBox();
            label10 = new Label();
            txtNotas = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // txtEstadoCita
            // 
            txtEstadoCita.Location = new Point(117, 201);
            txtEstadoCita.Name = "txtEstadoCita";
            txtEstadoCita.Size = new Size(174, 27);
            txtEstadoCita.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 201);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 59;
            label4.Text = "Estado:";
            // 
            // txtFechaSolicitud
            // 
            txtFechaSolicitud.Location = new Point(672, 156);
            txtFechaSolicitud.Name = "txtFechaSolicitud";
            txtFechaSolicitud.Size = new Size(174, 27);
            txtFechaSolicitud.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 156);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 57;
            label3.Text = "Fecha de solicitud:";
            // 
            // txtFechaCita
            // 
            txtFechaCita.Location = new Point(117, 149);
            txtFechaCita.Name = "txtFechaCita";
            txtFechaCita.Size = new Size(174, 27);
            txtFechaCita.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 152);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 55;
            label2.Text = "Fecha de Cita:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(392, 27);
            label1.Name = "label1";
            label1.Size = new Size(68, 38);
            label1.TabIndex = 54;
            label1.Text = "Cita";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(392, 201);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(174, 27);
            txtDuracion.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 201);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 61;
            label5.Text = "Duración:";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(672, 201);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(174, 27);
            txtHora.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(625, 201);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 63;
            label6.Text = "Hora:";
            // 
            // txtodontologo
            // 
            txtodontologo.Location = new Point(114, 254);
            txtodontologo.Name = "txtodontologo";
            txtodontologo.Size = new Size(312, 27);
            txtodontologo.TabIndex = 66;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 254);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 65;
            label7.Text = "Odontologo:";
            // 
            // txtPaciente
            // 
            txtPaciente.Location = new Point(547, 254);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(299, 27);
            txtPaciente.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(474, 254);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 67;
            label8.Text = "Paciente:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(117, 304);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ScrollBars = ScrollBars.Vertical;
            txtMotivo.Size = new Size(729, 71);
            txtMotivo.TabIndex = 70;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 304);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 69;
            label9.Text = "Motivo:";
            // 
            // txtIdCita
            // 
            txtIdCita.Location = new Point(119, 98);
            txtIdCita.Name = "txtIdCita";
            txtIdCita.ReadOnly = true;
            txtIdCita.Size = new Size(289, 27);
            txtIdCita.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 101);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 71;
            label10.Text = "Folio Cita:";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(117, 381);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.ScrollBars = ScrollBars.Vertical;
            txtNotas.Size = new Size(729, 79);
            txtNotas.TabIndex = 74;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 381);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 73;
            label11.Text = "Notas:";
            // 
            // ucCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(txtNotas);
            Controls.Add(label11);
            Controls.Add(txtIdCita);
            Controls.Add(label10);
            Controls.Add(txtMotivo);
            Controls.Add(label9);
            Controls.Add(txtPaciente);
            Controls.Add(label8);
            Controls.Add(txtodontologo);
            Controls.Add(label7);
            Controls.Add(txtHora);
            Controls.Add(label6);
            Controls.Add(txtDuracion);
            Controls.Add(label5);
            Controls.Add(txtEstadoCita);
            Controls.Add(label4);
            Controls.Add(txtFechaSolicitud);
            Controls.Add(label3);
            Controls.Add(txtFechaCita);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucCita";
            Size = new Size(884, 500);
            Load += ucCita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        public TextBox txtIdCita;
        public TextBox txtEstadoCita;
        public TextBox txtFechaSolicitud;
        public TextBox txtFechaCita;
        public TextBox txtDuracion;
        public TextBox txtHora;
        public TextBox txtodontologo;
        public TextBox txtPaciente;
        public TextBox txtMotivo;
        public TextBox txtNotas;
    }
}
