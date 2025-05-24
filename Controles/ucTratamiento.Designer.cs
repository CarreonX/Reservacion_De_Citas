namespace Controles
{
    partial class ucTratamiento
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
            btnGuardar = new Button();
            btnQuitar = new Button();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtServicio = new TextBox();
            label4 = new Label();
            label1 = new Label();
            cbBusqueda = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            panelDGV = new Panel();
            dgvTratamientos = new DataGridView();
            panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(145, 255);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(215, 54);
            btnGuardar.TabIndex = 116;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Enabled = false;
            btnQuitar.FlatAppearance.BorderSize = 0;
            btnQuitar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnQuitar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuitar.Location = new Point(473, 255);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(215, 54);
            btnQuitar.TabIndex = 114;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Enabled = false;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(761, 255);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(215, 54);
            btnAgregar.TabIndex = 113;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(962, 179);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(116, 27);
            txtPrecio.TabIndex = 112;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(694, 179);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(116, 27);
            txtCantidad.TabIndex = 111;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtServicio
            // 
            txtServicio.Location = new Point(269, 179);
            txtServicio.Name = "txtServicio";
            txtServicio.ReadOnly = true;
            txtServicio.Size = new Size(287, 27);
            txtServicio.TabIndex = 110;
            txtServicio.TextChanged += txtServicio_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(600, 183);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 109;
            label4.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 183);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 108;
            label1.Text = "Medicamento/Servicio:";
            // 
            // cbBusqueda
            // 
            cbBusqueda.Anchor = AnchorStyles.None;
            cbBusqueda.BackColor = SystemColors.ButtonFace;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(269, 113);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(364, 28);
            cbBusqueda.TabIndex = 107;
            cbBusqueda.SelectedIndexChanged += cbBusqueda_SelectedIndexChanged;
            cbBusqueda.TextChanged += cbBusqueda_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 118);
            label3.Name = "label3";
            label3.Size = new Size(182, 23);
            label3.TabIndex = 106;
            label3.Text = "Buscar Medicamento:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(476, 25);
            label2.Name = "label2";
            label2.Size = new Size(177, 38);
            label2.TabIndex = 105;
            label2.Text = "Tratamiento";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(892, 183);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 117;
            label5.Text = "Precio:";
            // 
            // panelDGV
            // 
            panelDGV.Controls.Add(dgvTratamientos);
            panelDGV.Dock = DockStyle.Bottom;
            panelDGV.Location = new Point(0, 330);
            panelDGV.Name = "panelDGV";
            panelDGV.Size = new Size(1185, 502);
            panelDGV.TabIndex = 118;
            // 
            // dgvTratamientos
            // 
            dgvTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTratamientos.Dock = DockStyle.Fill;
            dgvTratamientos.Location = new Point(0, 0);
            dgvTratamientos.Name = "dgvTratamientos";
            dgvTratamientos.RowHeadersWidth = 51;
            dgvTratamientos.Size = new Size(1185, 502);
            dgvTratamientos.TabIndex = 0;
            dgvTratamientos.CellClick += dgvTratamientos_CellClick;
            dgvTratamientos.Click += dgvTratamientos_Click;
            // 
            // ucTratamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(panelDGV);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtServicio);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cbBusqueda);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ucTratamiento";
            Size = new Size(1185, 832);
            panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Button btnQuitar;
        private Button btnAgregar;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtServicio;
        private Label label4;
        private Label label1;
        private ComboBox cbBusqueda;
        private Label label3;
        private Label label2;
        private Label label5;
        private Panel panelDGV;
        private DataGridView dgvTratamientos;
    }
}
