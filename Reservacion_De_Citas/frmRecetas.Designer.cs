namespace Formularios
{
    partial class frmRecetas
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
            label1 = new Label();
            dgvConsultas = new DataGridView();
            panel1 = new Panel();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblMensajeBusqueda = new Label();
            cbBusqueda = new ComboBox();
            label3 = new Label();
            flpConsulta = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(499, 34);
            label1.Name = "label1";
            label1.Size = new Size(115, 38);
            label1.TabIndex = 3;
            label1.Text = "Recetas";
            // 
            // dgvConsultas
            // 
            dgvConsultas.Anchor = AnchorStyles.None;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(23, 240);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.RowHeadersWidth = 51;
            dgvConsultas.Size = new Size(1230, 554);
            dgvConsultas.TabIndex = 92;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(1003, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 212);
            panel1.TabIndex = 91;
            // 
            // btnGuardar
            // 
            btnGuardar.Dock = DockStyle.Top;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(0, 150);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(250, 50);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Top;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnModificar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(0, 100);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(250, 50);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Top;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(0, 50);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(250, 50);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Dock = DockStyle.Top;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(0, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(250, 50);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblMensajeBusqueda
            // 
            lblMensajeBusqueda.Anchor = AnchorStyles.None;
            lblMensajeBusqueda.AutoSize = true;
            lblMensajeBusqueda.FlatStyle = FlatStyle.Flat;
            lblMensajeBusqueda.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeBusqueda.ForeColor = SystemColors.InactiveCaption;
            lblMensajeBusqueda.Location = new Point(489, 116);
            lblMensajeBusqueda.Name = "lblMensajeBusqueda";
            lblMensajeBusqueda.Size = new Size(284, 23);
            lblMensajeBusqueda.TabIndex = 90;
            lblMensajeBusqueda.Text = "Solo se aceptan numeros positivos";
            lblMensajeBusqueda.Visible = false;
            // 
            // cbBusqueda
            // 
            cbBusqueda.Anchor = AnchorStyles.None;
            cbBusqueda.BackColor = SystemColors.ButtonFace;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(109, 115);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(364, 28);
            cbBusqueda.TabIndex = 89;
            cbBusqueda.TextChanged += cbBusqueda_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 120);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 88;
            label3.Text = "Buscar:";
            // 
            // flpConsulta
            // 
            flpConsulta.AutoScroll = true;
            flpConsulta.Dock = DockStyle.Bottom;
            flpConsulta.FlowDirection = FlowDirection.TopDown;
            flpConsulta.Location = new Point(0, 300);
            flpConsulta.Name = "flpConsulta";
            flpConsulta.Size = new Size(1278, 524);
            flpConsulta.TabIndex = 87;
            flpConsulta.Visible = false;
            // 
            // frmRecetas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1278, 824);
            Controls.Add(dgvConsultas);
            Controls.Add(panel1);
            Controls.Add(lblMensajeBusqueda);
            Controls.Add(cbBusqueda);
            Controls.Add(label3);
            Controls.Add(flpConsulta);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRecetas";
            Text = "frmRecetas";
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvConsultas;
        private Panel panel1;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblMensajeBusqueda;
        private ComboBox cbBusqueda;
        private Label label3;
        private FlowLayoutPanel flpConsulta;
    }
}