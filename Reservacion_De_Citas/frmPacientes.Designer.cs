namespace Formularios
{
    partial class frmPacientes
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
            lblMensajeBusqueda = new Label();
            panel1 = new Panel();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            dgvPacientes = new DataGridView();
            cbBusqueda = new ComboBox();
            label3 = new Label();
            ucPaciente1 = new Controles.ucPaciente();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(592, 39);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 3;
            label1.Text = "Pacientes";
            // 
            // lblMensajeBusqueda
            // 
            lblMensajeBusqueda.Anchor = AnchorStyles.None;
            lblMensajeBusqueda.AutoSize = true;
            lblMensajeBusqueda.FlatStyle = FlatStyle.Flat;
            lblMensajeBusqueda.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeBusqueda.ForeColor = SystemColors.InactiveCaption;
            lblMensajeBusqueda.Location = new Point(559, 105);
            lblMensajeBusqueda.Name = "lblMensajeBusqueda";
            lblMensajeBusqueda.Size = new Size(208, 23);
            lblMensajeBusqueda.TabIndex = 13;
            lblMensajeBusqueda.Text = "Solo se aceptan numeros";
            lblMensajeBusqueda.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(1079, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 157);
            panel1.TabIndex = 11;
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
            // dgvPacientes
            // 
            dgvPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(12, 154);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(1343, 213);
            dgvPacientes.TabIndex = 10;
            // 
            // cbBusqueda
            // 
            cbBusqueda.Anchor = AnchorStyles.None;
            cbBusqueda.BackColor = SystemColors.ButtonFace;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(179, 104);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(364, 28);
            cbBusqueda.TabIndex = 9;
            cbBusqueda.TextChanged += cbBusqueda_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 109);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 8;
            label3.Text = "Buscar:";
            // 
            // ucPaciente1
            // 
            ucPaciente1.Anchor = AnchorStyles.None;
            ucPaciente1.BackColor = SystemColors.WindowFrame;
            ucPaciente1.Location = new Point(96, 382);
            ucPaciente1.Name = "ucPaciente1";
            ucPaciente1.Size = new Size(902, 877);
            ucPaciente1.TabIndex = 14;
            // 
            // frmPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1367, 1102);
            Controls.Add(ucPaciente1);
            Controls.Add(lblMensajeBusqueda);
            Controls.Add(panel1);
            Controls.Add(dgvPacientes);
            Controls.Add(cbBusqueda);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPacientes";
            Text = "frmPacientes";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMensajeBusqueda;
        private Panel panel1;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dgvPacientes;
        private ComboBox cbBusqueda;
        private Label label3;
        private Controles.ucPaciente ucPaciente1;
    }
}