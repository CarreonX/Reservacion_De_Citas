namespace Formularios
{
    partial class frmPrueba
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
            panel1 = new Panel();
            ucOdontologo1 = new Controles.ucOdontologo();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(ucOdontologo1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 504);
            panel1.TabIndex = 0;
            // 
            // ucOdontologo1
            // 
            ucOdontologo1.BackColor = Color.LightBlue;
            ucOdontologo1.Dock = DockStyle.Fill;
            ucOdontologo1.Location = new Point(0, 0);
            ucOdontologo1.Name = "ucOdontologo1";
            ucOdontologo1.Size = new Size(946, 504);
            ucOdontologo1.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.Silver;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            btnModificar.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(58, 587);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(104, 40);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            btnEliminar.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(207, 587);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 40);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.Silver;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            btnAgregar.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(365, 587);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 40);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.BackColor = Color.Silver;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(592, 589);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(314, 28);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(531, 597);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 5;
            label1.Text = "Buscar:";
            // 
            // frmPrueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(946, 706);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrueba";
            Text = "frmPrueba";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private ComboBox comboBox1;
        private Label label1;
        private Controles.ucOdontologo ucOdontologo1;
    }
}