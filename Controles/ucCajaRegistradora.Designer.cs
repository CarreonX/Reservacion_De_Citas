namespace Controles
{
    partial class ucCajaRegistradora
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
            txtDineroAlDia = new TextBox();
            label13 = new Label();
            txtTotal = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtFecha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtDineroAlDia
            // 
            txtDineroAlDia.Location = new Point(153, 454);
            txtDineroAlDia.Name = "txtDineroAlDia";
            txtDineroAlDia.Size = new Size(152, 27);
            txtDineroAlDia.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 457);
            label13.Name = "label13";
            label13.Size = new Size(110, 20);
            label13.TabIndex = 40;
            label13.Text = "Dinero al dia $:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(398, 454);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(152, 27);
            txtTotal.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 457);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 32;
            label6.Text = "Total $:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 153);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 30;
            label7.Text = "Productos:";
            // 
            // txtId
            // 
            txtId.Location = new Point(380, 94);
            txtId.Name = "txtId";
            txtId.Size = new Size(170, 27);
            txtId.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 97);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 26;
            label3.Text = "Folio:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(89, 94);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(174, 27);
            txtFecha.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 97);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 24;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 23);
            label1.Name = "label1";
            label1.Size = new Size(246, 38);
            label1.TabIndex = 23;
            label1.Text = "Caja Registradora";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(757, 282);
            dataGridView1.TabIndex = 47;
            // 
            // ucCajaRegistradora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dataGridView1);
            Controls.Add(txtDineroAlDia);
            Controls.Add(label13);
            Controls.Add(txtTotal);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(txtFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucCajaRegistradora";
            Size = new Size(884, 500);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDineroAlDia;
        private Label label13;
        private TextBox txtTotal;
        private Label label6;
        private Label label7;
        private TextBox txtId;
        private Label label3;
        private TextBox txtFecha;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
