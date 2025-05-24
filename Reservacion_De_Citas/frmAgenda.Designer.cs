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
            textBox1 = new TextBox();
            txtCitas = new TextBox();
            txtConsultas = new TextBox();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.None;
            monthCalendar1.BackColor = SystemColors.ControlDarkDark;
            monthCalendar1.CalendarDimensions = new Size(2, 1);
            monthCalendar1.Location = new Point(63, 192);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 44);
            label1.Name = "label1";
            label1.Size = new Size(237, 38);
            label1.TabIndex = 1;
            label1.Text = "Citas y Consultas";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(63, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 2;
            // 
            // txtCitas
            // 
            txtCitas.Anchor = AnchorStyles.None;
            txtCitas.BackColor = SystemColors.ScrollBar;
            txtCitas.Location = new Point(362, 458);
            txtCitas.Multiline = true;
            txtCitas.Name = "txtCitas";
            txtCitas.ReadOnly = true;
            txtCitas.Size = new Size(285, 207);
            txtCitas.TabIndex = 3;
            txtCitas.Visible = false;
            // 
            // txtConsultas
            // 
            txtConsultas.Anchor = AnchorStyles.None;
            txtConsultas.BackColor = SystemColors.ScrollBar;
            txtConsultas.Location = new Point(63, 458);
            txtConsultas.Multiline = true;
            txtConsultas.Name = "txtConsultas";
            txtConsultas.ReadOnly = true;
            txtConsultas.Size = new Size(275, 207);
            txtConsultas.TabIndex = 4;
            txtConsultas.Visible = false;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(842, 736);
            Controls.Add(txtConsultas);
            Controls.Add(txtCitas);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgenda";
            Text = "Agenda";
            Load += frmAgenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private TextBox textBox1;
        private TextBox txtCitas;
        private TextBox txtConsultas;
    }
}