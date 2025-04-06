namespace Controles
{
    partial class ucReceta
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
            textBox7 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox7
            // 
            textBox7.Location = new Point(131, 369);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ScrollBars = ScrollBars.Vertical;
            textBox7.Size = new Size(729, 91);
            textBox7.TabIndex = 95;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 369);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 94;
            label11.Text = "Indicaciones:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(131, 86);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(289, 27);
            textBox6.TabIndex = 93;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 89);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 92;
            label10.Text = "Folio Receta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 187);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 90;
            label9.Text = "Medicamentos:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(553, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(299, 27);
            textBox4.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(480, 138);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 88;
            label8.Text = "Paciente:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 27);
            textBox3.TabIndex = 87;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 138);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 86;
            label7.Text = "Odontologo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(553, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(307, 27);
            txtNombre.TabIndex = 77;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 92);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 76;
            label2.Text = "Fecha de Cita:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 20);
            label1.Name = "label1";
            label1.Size = new Size(103, 38);
            label1.TabIndex = 75;
            label1.Text = "Receta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(128, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(732, 176);
            dataGridView1.TabIndex = 96;
            // 
            // ucReceta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dataGridView1);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucReceta";
            Size = new Size(884, 472);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox7;
        private Label label11;
        private TextBox textBox6;
        private Label label10;
        private Label label9;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
