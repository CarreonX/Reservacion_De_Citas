namespace Controles
{
    partial class ucPresupuesto
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
            textBox6 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            txtApellidoM = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(133, 83);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(289, 27);
            textBox6.TabIndex = 93;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 86);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 92;
            label10.Text = "Folio Presupuesto:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 185);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 90;
            label9.Text = "Tratamiento:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(599, 388);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 27);
            textBox4.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(488, 388);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 88;
            label8.Text = "Monto Total $:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 388);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 27);
            textBox3.TabIndex = 87;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 388);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 86;
            label7.Text = "Tipo de trabajo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(534, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 83;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 152);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 82;
            label5.Text = "Paciente:";
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location = new Point(131, 152);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(319, 27);
            txtApellidoM.TabIndex = 81;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 152);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 80;
            label4.Text = "Odontologo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(416, 27);
            txtNombre.TabIndex = 77;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 122);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 76;
            label2.Text = "Fecha y Hora:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 19);
            label1.Name = "label1";
            label1.Size = new Size(178, 38);
            label1.TabIndex = 75;
            label1.Text = "Presupuesto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(131, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(729, 179);
            dataGridView1.TabIndex = 94;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 433);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(650, 57);
            textBox2.TabIndex = 96;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 433);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 95;
            label3.Text = "Ubicación de Boca:";
            // 
            // ucPresupuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(txtApellidoM);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucPresupuesto";
            Size = new Size(884, 500);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox6;
        private Label label10;
        private Label label9;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox1;
        private Label label5;
        private TextBox txtApellidoM;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label3;
    }
}
