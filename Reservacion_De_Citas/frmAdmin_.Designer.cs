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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin_));
            panelMenuLateral = new Panel();
            btnCerrarSesion = new Button();
            panelSubMenuUsuarios = new Panel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button15 = new Button();
            button2 = new Button();
            panelSubMenuReportes = new Panel();
            button12 = new Button();
            button7 = new Button();
            button1 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button6 = new Button();
            btnReportes = new Button();
            panelLogo = new Panel();
            panelFormulario = new Panel();
            lblFechaHota = new Label();
            lblBienvenida = new Label();
            panelMenuLateral.SuspendLayout();
            panelSubMenuUsuarios.SuspendLayout();
            panelSubMenuReportes.SuspendLayout();
            panelFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.Silver;
            panelMenuLateral.Controls.Add(btnCerrarSesion);
            panelMenuLateral.Controls.Add(panelSubMenuUsuarios);
            panelMenuLateral.Controls.Add(button2);
            panelMenuLateral.Controls.Add(panelSubMenuReportes);
            panelMenuLateral.Controls.Add(button6);
            panelMenuLateral.Controls.Add(btnReportes);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 753);
            panelMenuLateral.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = SystemColors.InfoText;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.Location = new Point(0, 708);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(10, 0, 10, 0);
            btnCerrarSesion.Size = new Size(250, 45);
            btnCerrarSesion.TabIndex = 12;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelSubMenuUsuarios
            // 
            panelSubMenuUsuarios.BackColor = SystemColors.GradientInactiveCaption;
            panelSubMenuUsuarios.Controls.Add(button3);
            panelSubMenuUsuarios.Controls.Add(button4);
            panelSubMenuUsuarios.Controls.Add(button5);
            panelSubMenuUsuarios.Controls.Add(button15);
            panelSubMenuUsuarios.Dock = DockStyle.Top;
            panelSubMenuUsuarios.Location = new Point(0, 443);
            panelSubMenuUsuarios.Name = "panelSubMenuUsuarios";
            panelSubMenuUsuarios.Size = new Size(250, 125);
            panelSubMenuUsuarios.TabIndex = 9;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.InfoText;
            button3.Location = new Point(0, 87);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(250, 29);
            button3.TabIndex = 3;
            button3.Text = "Secretarias";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.InfoText;
            button4.Location = new Point(0, 58);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(250, 29);
            button4.TabIndex = 2;
            button4.Text = "Pacientes";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button5.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.InfoText;
            button5.Location = new Point(0, 29);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(250, 29);
            button5.TabIndex = 1;
            button5.Text = "Dentistas";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Top;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button15.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = SystemColors.InfoText;
            button15.Location = new Point(0, 0);
            button15.Name = "button15";
            button15.Padding = new Padding(35, 0, 0, 0);
            button15.Size = new Size(250, 29);
            button15.TabIndex = 0;
            button15.Text = "Administradores";
            button15.TextAlign = ContentAlignment.MiddleLeft;
            button15.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(0, 398);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(250, 45);
            button2.TabIndex = 8;
            button2.Text = "Usuarios";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // panelSubMenuReportes
            // 
            panelSubMenuReportes.BackColor = SystemColors.GradientInactiveCaption;
            panelSubMenuReportes.Controls.Add(button12);
            panelSubMenuReportes.Controls.Add(button7);
            panelSubMenuReportes.Controls.Add(button1);
            panelSubMenuReportes.Controls.Add(button8);
            panelSubMenuReportes.Controls.Add(button9);
            panelSubMenuReportes.Controls.Add(button10);
            panelSubMenuReportes.Controls.Add(button11);
            panelSubMenuReportes.Dock = DockStyle.Top;
            panelSubMenuReportes.Location = new Point(0, 190);
            panelSubMenuReportes.Name = "panelSubMenuReportes";
            panelSubMenuReportes.Size = new Size(250, 208);
            panelSubMenuReportes.TabIndex = 6;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Top;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button12.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = SystemColors.InfoText;
            button12.Location = new Point(0, 174);
            button12.Name = "button12";
            button12.Padding = new Padding(35, 0, 0, 0);
            button12.Size = new Size(250, 29);
            button12.TabIndex = 7;
            button12.Text = "Recetas";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button7.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.InfoText;
            button7.Location = new Point(0, 145);
            button7.Name = "button7";
            button7.Padding = new Padding(35, 0, 0, 0);
            button7.Size = new Size(250, 29);
            button7.TabIndex = 6;
            button7.Text = "Presupuestos";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(0, 116);
            button1.Name = "button1";
            button1.Padding = new Padding(35, 0, 0, 0);
            button1.Size = new Size(250, 29);
            button1.TabIndex = 5;
            button1.Text = "Guardados";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button8.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.InfoText;
            button8.Location = new Point(0, 87);
            button8.Name = "button8";
            button8.Padding = new Padding(35, 0, 0, 0);
            button8.Size = new Size(250, 29);
            button8.TabIndex = 3;
            button8.Text = "Consultas Medicas";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button9.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = SystemColors.InfoText;
            button9.Location = new Point(0, 58);
            button9.Name = "button9";
            button9.Padding = new Padding(35, 0, 0, 0);
            button9.Size = new Size(250, 29);
            button9.TabIndex = 2;
            button9.Text = "Citas";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button10.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = SystemColors.InfoText;
            button10.Location = new Point(0, 29);
            button10.Name = "button10";
            button10.Padding = new Padding(35, 0, 0, 0);
            button10.Size = new Size(250, 29);
            button10.TabIndex = 1;
            button10.Text = "Cajas Registradoras";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Top;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button11.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = SystemColors.InfoText;
            button11.Location = new Point(0, 0);
            button11.Name = "button11";
            button11.Padding = new Padding(35, 0, 0, 0);
            button11.Size = new Size(250, 29);
            button11.TabIndex = 0;
            button11.Text = "Almacen";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.InfoText;
            button6.Location = new Point(0, 145);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(250, 45);
            button6.TabIndex = 5;
            button6.Text = "Reportes";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
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
            btnReportes.Text = "Agenda";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 0;
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(lblFechaHota);
            panelFormulario.Controls.Add(lblBienvenida);
            panelFormulario.Dock = DockStyle.Fill;
            panelFormulario.Location = new Point(250, 0);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(893, 753);
            panelFormulario.TabIndex = 1;
            // 
            // lblFechaHota
            // 
            lblFechaHota.AutoSize = true;
            lblFechaHota.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaHota.Location = new Point(88, 76);
            lblFechaHota.Name = "lblFechaHota";
            lblFechaHota.Size = new Size(96, 38);
            lblFechaHota.TabIndex = 1;
            lblFechaHota.Text = "label2";
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(163, 177);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(360, 60);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Alberto Carreon";
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
            panelSubMenuUsuarios.ResumeLayout(false);
            panelSubMenuReportes.ResumeLayout(false);
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Button btnReportes;
        private Panel panelLogo;
        private Panel panelFormulario;
        private Panel panelSubMenuReportes;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button6;
        private Panel panelSubMenuUsuarios;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button15;
        private Button button2;
        private Button button1;
        private Label lblFechaHota;
        private Label lblBienvenida;
        private Button btnCerrarSesion;
        private Button button12;
        private Button button7;
    }
}