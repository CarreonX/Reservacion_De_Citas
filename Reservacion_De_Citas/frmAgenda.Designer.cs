namespace Formularios
{
    partial class frmAgenda
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            panelPrincipal = new Panel();
            panelConsultas = new Panel();
            dgvConsultas = new DataGridView();
            lblNoConsultas = new Label();
            label4 = new Label();
            panelCitas = new Panel();
            dgvCitas = new DataGridView();
            lblNoCitas = new Label();
            label2 = new Label();
            panelPrincipal.SuspendLayout();
            panelConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            panelCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.ControlDarkDark;
            monthCalendar1.CalendarDimensions = new Size(2, 1);
            monthCalendar1.Location = new Point(154, 99);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 39);
            label1.Name = "label1";
            label1.Size = new Size(237, 38);
            label1.TabIndex = 1;
            label1.Text = "Citas y Consultas";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(panelConsultas);
            panelPrincipal.Controls.Add(panelCitas);
            panelPrincipal.Dock = DockStyle.Bottom;
            panelPrincipal.Location = new Point(0, 329);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(893, 629);
            panelPrincipal.TabIndex = 2;
            // 
            // panelConsultas
            // 
            panelConsultas.Controls.Add(dgvConsultas);
            panelConsultas.Controls.Add(lblNoConsultas);
            panelConsultas.Controls.Add(label4);
            panelConsultas.Dock = DockStyle.Bottom;
            panelConsultas.Location = new Point(0, 319);
            panelConsultas.Name = "panelConsultas";
            panelConsultas.Size = new Size(893, 310);
            panelConsultas.TabIndex = 1;
            // 
            // dgvConsultas
            // 
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(3, 48);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.RowHeadersWidth = 51;
            dgvConsultas.Size = new Size(887, 259);
            dgvConsultas.TabIndex = 2;
            dgvConsultas.Visible = false;
            // 
            // lblNoConsultas
            // 
            lblNoConsultas.AutoSize = true;
            lblNoConsultas.Location = new Point(347, 14);
            lblNoConsultas.Name = "lblNoConsultas";
            lblNoConsultas.Size = new Size(188, 20);
            lblNoConsultas.TabIndex = 1;
            lblNoConsultas.Text = "Sin concultas programadas";
            lblNoConsultas.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 14);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 0;
            label4.Text = "Consultas Programadas:";
            // 
            // panelCitas
            // 
            panelCitas.Controls.Add(dgvCitas);
            panelCitas.Controls.Add(lblNoCitas);
            panelCitas.Controls.Add(label2);
            panelCitas.Location = new Point(0, 3);
            panelCitas.Name = "panelCitas";
            panelCitas.Size = new Size(894, 309);
            panelCitas.TabIndex = 0;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(3, 48);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new Size(887, 258);
            dgvCitas.TabIndex = 2;
            dgvCitas.Visible = false;
            // 
            // lblNoCitas
            // 
            lblNoCitas.AutoSize = true;
            lblNoCitas.Location = new Point(360, 14);
            lblNoCitas.Name = "lblNoCitas";
            lblNoCitas.Size = new Size(156, 20);
            lblNoCitas.TabIndex = 1;
            lblNoCitas.Text = "Sin citas programadas";
            lblNoCitas.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 0;
            label2.Text = "Citas Programadas:";
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(893, 958);
            Controls.Add(panelPrincipal);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgenda";
            Text = "Agenda";
            panelPrincipal.ResumeLayout(false);
            panelConsultas.ResumeLayout(false);
            panelConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            panelCitas.ResumeLayout(false);
            panelCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private Panel panelPrincipal;
        private Panel panelCitas;
        private Label lblNoCitas;
        private Label label2;
        private DataGridView dgvCitas;
        private Panel panelConsultas;
        private DataGridView dgvConsultas;
        private Label lblNoConsultas;
        private Label label4;
    }
}