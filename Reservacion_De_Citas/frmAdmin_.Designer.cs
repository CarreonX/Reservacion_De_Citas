namespace Formularios
{
    partial class frmAdmin_
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
            panelMenuLateral = new Panel();
            panelSubMenuSeguridad = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnSubMenuSeguridad = new Button();
            panelSubMenuReportes = new Panel();
            btnFinanzas = new Button();
            btnAlmacen = new Button();
            btnConsultasMedicas = new Button();
            btnCitas = new Button();
            btnReportes = new Button();
            panelLogo = new Panel();
            panelFormulario = new Panel();
            panelMenuLateral.SuspendLayout();
            panelSubMenuSeguridad.SuspendLayout();
            panelSubMenuReportes.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.Silver;
            panelMenuLateral.Controls.Add(panelSubMenuSeguridad);
            panelMenuLateral.Controls.Add(btnSubMenuSeguridad);
            panelMenuLateral.Controls.Add(panelSubMenuReportes);
            panelMenuLateral.Controls.Add(btnReportes);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 753);
            panelMenuLateral.TabIndex = 0;
            // 
            // panelSubMenuSeguridad
            // 
            panelSubMenuSeguridad.BackColor = SystemColors.GradientInactiveCaption;
            panelSubMenuSeguridad.Controls.Add(button2);
            panelSubMenuSeguridad.Controls.Add(button3);
            panelSubMenuSeguridad.Controls.Add(button4);
            panelSubMenuSeguridad.Dock = DockStyle.Top;
            panelSubMenuSeguridad.Location = new Point(0, 312);
            panelSubMenuSeguridad.Name = "panelSubMenuSeguridad";
            panelSubMenuSeguridad.Size = new Size(250, 91);
            panelSubMenuSeguridad.TabIndex = 4;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(0, 58);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(250, 29);
            button2.TabIndex = 2;
            button2.Text = "Inventario";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.InfoText;
            button3.Location = new Point(0, 29);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(250, 29);
            button3.TabIndex = 1;
            button3.Text = "Movimientos  de finanzas";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.InfoText;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(250, 29);
            button4.TabIndex = 0;
            button4.Text = "Inicios de Sesión";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnSubMenuSeguridad
            // 
            btnSubMenuSeguridad.Dock = DockStyle.Top;
            btnSubMenuSeguridad.FlatAppearance.BorderSize = 0;
            btnSubMenuSeguridad.FlatStyle = FlatStyle.Flat;
            btnSubMenuSeguridad.ForeColor = SystemColors.InfoText;
            btnSubMenuSeguridad.Location = new Point(0, 267);
            btnSubMenuSeguridad.Name = "btnSubMenuSeguridad";
            btnSubMenuSeguridad.Padding = new Padding(10, 0, 0, 0);
            btnSubMenuSeguridad.Size = new Size(250, 45);
            btnSubMenuSeguridad.TabIndex = 3;
            btnSubMenuSeguridad.Text = "Seguridad";
            btnSubMenuSeguridad.TextAlign = ContentAlignment.MiddleLeft;
            btnSubMenuSeguridad.UseVisualStyleBackColor = true;
            btnSubMenuSeguridad.Click += btnSubMenuSeguridad_Click;
            // 
            // panelSubMenuReportes
            // 
            panelSubMenuReportes.BackColor = SystemColors.GradientInactiveCaption;
            panelSubMenuReportes.Controls.Add(btnFinanzas);
            panelSubMenuReportes.Controls.Add(btnAlmacen);
            panelSubMenuReportes.Controls.Add(btnConsultasMedicas);
            panelSubMenuReportes.Controls.Add(btnCitas);
            panelSubMenuReportes.Dock = DockStyle.Top;
            panelSubMenuReportes.Location = new Point(0, 145);
            panelSubMenuReportes.Name = "panelSubMenuReportes";
            panelSubMenuReportes.Size = new Size(250, 122);
            panelSubMenuReportes.TabIndex = 2;
            // 
            // btnFinanzas
            // 
            btnFinanzas.Dock = DockStyle.Top;
            btnFinanzas.FlatAppearance.BorderSize = 0;
            btnFinanzas.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnFinanzas.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnFinanzas.FlatStyle = FlatStyle.Flat;
            btnFinanzas.ForeColor = SystemColors.InfoText;
            btnFinanzas.Location = new Point(0, 87);
            btnFinanzas.Name = "btnFinanzas";
            btnFinanzas.Padding = new Padding(35, 0, 0, 0);
            btnFinanzas.Size = new Size(250, 29);
            btnFinanzas.TabIndex = 3;
            btnFinanzas.Text = "Finanzas";
            btnFinanzas.TextAlign = ContentAlignment.MiddleLeft;
            btnFinanzas.UseVisualStyleBackColor = true;
            btnFinanzas.Click += btnFinanzas_Click;
            // 
            // btnAlmacen
            // 
            btnAlmacen.Dock = DockStyle.Top;
            btnAlmacen.FlatAppearance.BorderSize = 0;
            btnAlmacen.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnAlmacen.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnAlmacen.FlatStyle = FlatStyle.Flat;
            btnAlmacen.ForeColor = SystemColors.InfoText;
            btnAlmacen.Location = new Point(0, 58);
            btnAlmacen.Name = "btnAlmacen";
            btnAlmacen.Padding = new Padding(35, 0, 0, 0);
            btnAlmacen.Size = new Size(250, 29);
            btnAlmacen.TabIndex = 2;
            btnAlmacen.Text = "Almacen";
            btnAlmacen.TextAlign = ContentAlignment.MiddleLeft;
            btnAlmacen.UseVisualStyleBackColor = true;
            btnAlmacen.Click += btnAlmacen_Click;
            // 
            // btnConsultasMedicas
            // 
            btnConsultasMedicas.Dock = DockStyle.Top;
            btnConsultasMedicas.FlatAppearance.BorderSize = 0;
            btnConsultasMedicas.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnConsultasMedicas.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnConsultasMedicas.FlatStyle = FlatStyle.Flat;
            btnConsultasMedicas.ForeColor = SystemColors.InfoText;
            btnConsultasMedicas.Location = new Point(0, 29);
            btnConsultasMedicas.Name = "btnConsultasMedicas";
            btnConsultasMedicas.Padding = new Padding(35, 0, 0, 0);
            btnConsultasMedicas.Size = new Size(250, 29);
            btnConsultasMedicas.TabIndex = 1;
            btnConsultasMedicas.Text = "Consultas Medicas";
            btnConsultasMedicas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultasMedicas.UseVisualStyleBackColor = true;
            btnConsultasMedicas.Click += btnConsultasMedicas_Click;
            // 
            // btnCitas
            // 
            btnCitas.Dock = DockStyle.Top;
            btnCitas.FlatAppearance.BorderSize = 0;
            btnCitas.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnCitas.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.ForeColor = SystemColors.InfoText;
            btnCitas.Location = new Point(0, 0);
            btnCitas.Name = "btnCitas";
            btnCitas.Padding = new Padding(35, 0, 0, 0);
            btnCitas.Size = new Size(250, 29);
            btnCitas.TabIndex = 0;
            btnCitas.Text = "Citas";
            btnCitas.TextAlign = ContentAlignment.MiddleLeft;
            btnCitas.UseVisualStyleBackColor = true;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = SystemColors.InfoText;
            btnReportes.Location = new Point(0, 100);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(10, 0, 0, 0);
            btnReportes.Size = new Size(250, 45);
            btnReportes.TabIndex = 1;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 0;
            // 
            // panelFormulario
            // 
            panelFormulario.Dock = DockStyle.Fill;
            panelFormulario.Location = new Point(250, 0);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(893, 753);
            panelFormulario.TabIndex = 1;
            // 
            // frmAdmin_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1143, 753);
            Controls.Add(panelFormulario);
            Controls.Add(panelMenuLateral);
            MinimumSize = new Size(950, 800);
            Name = "frmAdmin_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdmin_";
            panelMenuLateral.ResumeLayout(false);
            panelSubMenuSeguridad.ResumeLayout(false);
            panelSubMenuReportes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Button btnReportes;
        private Panel panelLogo;
        private Panel panelSubMenuReportes;
        private Button btnFinanzas;
        private Button btnAlmacen;
        private Button btnConsultasMedicas;
        private Button btnCitas;
        private Panel panelSubMenuSeguridad;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnSubMenuSeguridad;
        private Panel panelFormulario;
    }
}