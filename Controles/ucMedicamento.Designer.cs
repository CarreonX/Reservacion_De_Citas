namespace Controles
{
    partial class ucMedicamento
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
            label13 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtEstante = new TextBox();
            txtSeccion = new TextBox();
            txtDivicion = new TextBox();
            txtPiso = new TextBox();
            txtCantidad = new TextBox();
            txtUnidadMedida = new TextBox();
            txtSubTotal = new TextBox();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.WindowFrame;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(450, 281);
            label13.Name = "label13";
            label13.Size = new Size(39, 20);
            label13.TabIndex = 110;
            label13.Text = "Piso:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.WindowFrame;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(259, 446);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 108;
            label8.Text = "Subtotal:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.WindowFrame;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(599, 203);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 106;
            label9.Text = "Sección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowFrame;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(17, 203);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 104;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.WindowFrame;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(422, 121);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 102;
            label6.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.WindowFrame;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(31, 117);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 100;
            label7.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(303, 203);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 98;
            label4.Text = "Estante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-415, 218);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 96;
            label3.Text = "Divición:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(94, 284);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 94;
            label2.Text = "Divición:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(354, 35);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 93;
            label1.Text = "Medicamento";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonFace;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Location = new Point(64, 116);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(244, 20);
            txtId.TabIndex = 111;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ButtonFace;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(495, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(337, 20);
            txtNombre.TabIndex = 112;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.ButtonFace;
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Location = new Point(76, 200);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(206, 20);
            txtPrecio.TabIndex = 113;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtEstante
            // 
            txtEstante.BackColor = SystemColors.ButtonFace;
            txtEstante.BorderStyle = BorderStyle.None;
            txtEstante.Location = new Point(369, 200);
            txtEstante.Name = "txtEstante";
            txtEstante.Size = new Size(206, 20);
            txtEstante.TabIndex = 114;
            // 
            // txtSeccion
            // 
            txtSeccion.BackColor = SystemColors.ButtonFace;
            txtSeccion.BorderStyle = BorderStyle.None;
            txtSeccion.Location = new Point(668, 200);
            txtSeccion.Name = "txtSeccion";
            txtSeccion.Size = new Size(200, 20);
            txtSeccion.TabIndex = 115;
            // 
            // txtDivicion
            // 
            txtDivicion.BackColor = SystemColors.ButtonFace;
            txtDivicion.BorderStyle = BorderStyle.None;
            txtDivicion.Location = new Point(172, 278);
            txtDivicion.Name = "txtDivicion";
            txtDivicion.Size = new Size(188, 20);
            txtDivicion.TabIndex = 116;
            // 
            // txtPiso
            // 
            txtPiso.BackColor = SystemColors.ButtonFace;
            txtPiso.BorderStyle = BorderStyle.None;
            txtPiso.Location = new Point(508, 277);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(212, 20);
            txtPiso.TabIndex = 117;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.ButtonFace;
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Location = new Point(192, 370);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(171, 20);
            txtCantidad.TabIndex = 118;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtUnidadMedida
            // 
            txtUnidadMedida.BackColor = SystemColors.ButtonFace;
            txtUnidadMedida.BorderStyle = BorderStyle.None;
            txtUnidadMedida.Location = new Point(546, 370);
            txtUnidadMedida.Name = "txtUnidadMedida";
            txtUnidadMedida.Size = new Size(244, 20);
            txtUnidadMedida.TabIndex = 119;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = SystemColors.ButtonFace;
            txtSubTotal.BorderStyle = BorderStyle.None;
            txtSubTotal.Location = new Point(333, 443);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(244, 20);
            txtSubTotal.TabIndex = 120;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.WindowFrame;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(404, 373);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 121;
            label10.Text = "Unidad de Medida:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.WindowFrame;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(119, 373);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 122;
            label11.Text = "Cantidad:";
            // 
            // ucMedicamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtSubTotal);
            Controls.Add(txtUnidadMedida);
            Controls.Add(txtCantidad);
            Controls.Add(txtPiso);
            Controls.Add(txtDivicion);
            Controls.Add(txtSeccion);
            Controls.Add(txtEstante);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(255, 128, 0);
            Name = "ucMedicamento";
            Size = new Size(884, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label11;
        public TextBox txtId;
        public TextBox txtNombre;
        public TextBox txtPrecio;
        public TextBox txtEstante;
        public TextBox txtSeccion;
        public TextBox txtDivicion;
        public TextBox txtPiso;
        public TextBox txtCantidad;
        public TextBox txtUnidadMedida;
        public TextBox txtSubTotal;
    }
}
