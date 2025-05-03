namespace Formularios
{
    partial class frmSecretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecretaria));
            btnReportes = new Button();
            panelLogo = new Panel();
            panelMenuLateral = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnCerrarSesion = new Button();
            lblFechaHota = new Label();
            lblBienvenida = new Label();
            panelFormulario = new Panel();
            lblHoraFecha = new Label();
            button4 = new Button();
            button5 = new Button();
            panelMenuLateral.SuspendLayout();
            panelFormulario.SuspendLayout();
            SuspendLayout();
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
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.Silver;
            panelMenuLateral.Controls.Add(button5);
            panelMenuLateral.Controls.Add(button4);
            panelMenuLateral.Controls.Add(button3);
            panelMenuLateral.Controls.Add(button2);
            panelMenuLateral.Controls.Add(btnCerrarSesion);
            panelMenuLateral.Controls.Add(btnReportes);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 753);
            panelMenuLateral.TabIndex = 2;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.InfoText;
            button3.Location = new Point(0, 190);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(250, 45);
            button3.TabIndex = 14;
            button3.Text = "Medicamentos";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(0, 145);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(250, 45);
            button2.TabIndex = 13;
            button2.Text = "Caja Registradora";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
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
            btnCerrarSesion.TabIndex = 11;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
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
            lblBienvenida.Location = new Point(549, 230);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(360, 60);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Alberto Carreon";
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(lblHoraFecha);
            panelFormulario.Controls.Add(lblFechaHota);
            panelFormulario.Controls.Add(lblBienvenida);
            panelFormulario.Dock = DockStyle.Fill;
            panelFormulario.Location = new Point(0, 0);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1218, 753);
            panelFormulario.TabIndex = 3;
            // 
            // lblHoraFecha
            // 
            lblHoraFecha.AutoSize = true;
            lblHoraFecha.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraFecha.Location = new Point(327, 76);
            lblHoraFecha.Name = "lblHoraFecha";
            lblHoraFecha.Size = new Size(96, 38);
            lblHoraFecha.TabIndex = 2;
            lblHoraFecha.Text = "label2";
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.InfoText;
            button4.Location = new Point(0, 235);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(250, 45);
            button4.TabIndex = 15;
            button4.Text = "Pacientes";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.InfoText;
            button5.Location = new Point(0, 280);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(250, 45);
            button5.TabIndex = 16;
            button5.Text = "Recetas";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // frmSecretaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1218, 753);
            Controls.Add(panelMenuLateral);
            Controls.Add(panelFormulario);
            Name = "frmSecretaria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSecretaria";
            panelMenuLateral.ResumeLayout(false);
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnReportes;
        private Panel panelLogo;
        private Panel panelMenuLateral;
        private Label lblFechaHota;
        private Label lblBienvenida;
        private Panel panelFormulario;
        private Label lblHoraFecha;
        private Button btnCerrarSesion;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
    }
}