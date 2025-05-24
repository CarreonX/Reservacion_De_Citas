namespace Formularios
{
    partial class frmTratamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTratamiento));
            cbBusqueda = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtServicio = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            btnQuitar = new Button();
            panelDGV = new Panel();
            dataGridView1 = new DataGridView();
            btnAtras = new Button();
            btnGuardar = new Button();
            panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbBusqueda
            // 
            cbBusqueda.Anchor = AnchorStyles.None;
            cbBusqueda.BackColor = SystemColors.ButtonFace;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(245, 125);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(364, 28);
            cbBusqueda.TabIndex = 92;
            cbBusqueda.SelectedIndexChanged += cbBusqueda_SelectedIndexChanged;
            cbBusqueda.TextChanged += cbBusqueda_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 130);
            label3.Name = "label3";
            label3.Size = new Size(182, 23);
            label3.TabIndex = 91;
            label3.Text = "Buscar Medicamento:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 37);
            label2.Name = "label2";
            label2.Size = new Size(177, 38);
            label2.TabIndex = 90;
            label2.Text = "Tratamiento";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 207);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 93;
            label1.Text = "Medicamento/Servicio:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(561, 207);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 94;
            label4.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(809, 207);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 95;
            label5.Text = "Precio:$";
            // 
            // txtServicio
            // 
            txtServicio.Location = new Point(245, 203);
            txtServicio.Name = "txtServicio";
            txtServicio.ReadOnly = true;
            txtServicio.Size = new Size(287, 27);
            txtServicio.TabIndex = 96;
            txtServicio.TextChanged += txtServicio_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(667, 203);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(116, 27);
            txtCantidad.TabIndex = 97;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(889, 203);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(116, 27);
            txtPrecio.TabIndex = 98;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Enabled = false;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(721, 285);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(215, 54);
            btnAgregar.TabIndex = 99;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Enabled = false;
            btnQuitar.FlatAppearance.BorderSize = 0;
            btnQuitar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnQuitar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuitar.Location = new Point(412, 285);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(215, 54);
            btnQuitar.TabIndex = 100;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // panelDGV
            // 
            panelDGV.Controls.Add(dataGridView1);
            panelDGV.Dock = DockStyle.Bottom;
            panelDGV.Location = new Point(0, 372);
            panelDGV.Name = "panelDGV";
            panelDGV.Size = new Size(1110, 534);
            panelDGV.TabIndex = 101;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1110, 534);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnAtras
            // 
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAtras.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, -1);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 61);
            btnAtras.TabIndex = 102;
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(104, 285);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(215, 54);
            btnGuardar.TabIndex = 103;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmTratamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1110, 906);
            Controls.Add(btnGuardar);
            Controls.Add(btnAtras);
            Controls.Add(panelDGV);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtServicio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cbBusqueda);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTratamiento";
            Text = "frmTratamiento";
            panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbBusqueda;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtServicio;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnQuitar;
        private Panel panelDGV;
        private DataGridView dataGridView1;
        private Button btnAtras;
        private Button btnGuardar;
    }
}