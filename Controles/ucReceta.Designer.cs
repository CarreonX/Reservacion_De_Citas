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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReceta));
            txtIndicaciones = new TextBox();
            label11 = new Label();
            txtIdReceta = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtOdontologo = new TextBox();
            label7 = new Label();
            txtFecha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvMedicamentos = new DataGridView();
            cbPaciente = new ComboBox();
            flpTratamiento = new FlowLayoutPanel();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            flpTratamiento.SuspendLayout();
            SuspendLayout();
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(131, 386);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.ScrollBars = ScrollBars.Vertical;
            txtIndicaciones.Size = new Size(729, 91);
            txtIndicaciones.TabIndex = 95;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 386);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 94;
            label11.Text = "Indicaciones:";
            // 
            // txtIdReceta
            // 
            txtIdReceta.Location = new Point(128, 103);
            txtIdReceta.Name = "txtIdReceta";
            txtIdReceta.ReadOnly = true;
            txtIdReceta.Size = new Size(304, 27);
            txtIdReceta.TabIndex = 93;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 109);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 92;
            label10.Text = "Folio Receta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 204);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 90;
            label9.Text = "Medicamentos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(480, 155);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 88;
            label8.Text = "Paciente:";
            // 
            // txtOdontologo
            // 
            txtOdontologo.Location = new Point(128, 155);
            txtOdontologo.Name = "txtOdontologo";
            txtOdontologo.ReadOnly = true;
            txtOdontologo.Size = new Size(304, 27);
            txtOdontologo.TabIndex = 87;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 155);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 86;
            label7.Text = "Odontologo:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(553, 106);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(307, 27);
            txtFecha.TabIndex = 77;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 110);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 76;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 38);
            label1.TabIndex = 75;
            label1.Text = "Receta";
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(128, 204);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.Size = new Size(732, 176);
            dgvMedicamentos.TabIndex = 96;
            dgvMedicamentos.CellContentClick += dgvMedicamentos_CellContentClick;
            dgvMedicamentos.Click += dgvMedicamentos_Click;
            // 
            // cbPaciente
            // 
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new Point(553, 152);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new Size(307, 28);
            cbPaciente.TabIndex = 97;
            cbPaciente.SelectedIndexChanged += cbPaciente_SelectedIndexChanged;
            cbPaciente.TextChanged += cbPaciente_TextChanged;
            // 
            // flpTratamiento
            // 
            flpTratamiento.Controls.Add(btnAtras);
            flpTratamiento.Location = new Point(0, 0);
            flpTratamiento.Name = "flpTratamiento";
            flpTratamiento.Size = new Size(384, 97);
            flpTratamiento.TabIndex = 98;
            flpTratamiento.Visible = false;
            // 
            // btnAtras
            // 
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAtras.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(3, 3);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 61);
            btnAtras.TabIndex = 103;
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Visible = false;
            btnAtras.Click += btnAtras_Click_1;
            // 
            // ucReceta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(flpTratamiento);
            Controls.Add(cbPaciente);
            Controls.Add(dgvMedicamentos);
            Controls.Add(txtIndicaciones);
            Controls.Add(label11);
            Controls.Add(txtIdReceta);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtOdontologo);
            Controls.Add(label7);
            Controls.Add(txtFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucReceta";
            Size = new Size(884, 500);
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            flpTratamiento.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtOdontologo;
        private Label label7;
        private TextBox txtFecha;
        private Label label2;
        private Label label1;
        private DataGridView dgvMedicamentos;
        private ComboBox cbPaciente;
        private FlowLayoutPanel flpTratamiento;
        private Button btnAtras;
        public TextBox txtIndicaciones;
        public TextBox txtIdReceta;
    }
}
