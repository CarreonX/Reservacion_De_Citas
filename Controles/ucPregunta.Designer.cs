namespace Controles
{
    partial class ucPregunta
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
            txtPregunta = new RichTextBox();
            rbSi = new RadioButton();
            rbNo = new RadioButton();
            txtArgumento = new RichTextBox();
            label1 = new Label();
            lblIdPregunta = new Label();
            SuspendLayout();
            // 
            // txtPregunta
            // 
            txtPregunta.BorderStyle = BorderStyle.None;
            txtPregunta.Location = new Point(34, 5);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(416, 58);
            txtPregunta.TabIndex = 0;
            txtPregunta.Text = "";
            txtPregunta.TextChanged += txtPregunta_TextChanged;
            // 
            // rbSi
            // 
            rbSi.AutoSize = true;
            rbSi.Location = new Point(481, 24);
            rbSi.Name = "rbSi";
            rbSi.Size = new Size(42, 24);
            rbSi.TabIndex = 1;
            rbSi.TabStop = true;
            rbSi.Text = "Si";
            rbSi.UseVisualStyleBackColor = true;
            rbSi.CheckedChanged += rbSi_CheckedChanged;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(529, 24);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(50, 24);
            rbNo.TabIndex = 2;
            rbNo.TabStop = true;
            rbNo.Text = "No";
            rbNo.UseVisualStyleBackColor = true;
            rbNo.CheckedChanged += rbNo_CheckedChanged;
            // 
            // txtArgumento
            // 
            txtArgumento.BorderStyle = BorderStyle.None;
            txtArgumento.Location = new Point(688, 5);
            txtArgumento.Name = "txtArgumento";
            txtArgumento.Size = new Size(288, 58);
            txtArgumento.TabIndex = 3;
            txtArgumento.Text = "";
            txtArgumento.TextChanged += txtArgumento_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(595, 5);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 4;
            label1.Text = "Argumento:";
            // 
            // lblIdPregunta
            // 
            lblIdPregunta.AutoSize = true;
            lblIdPregunta.Location = new Point(3, 24);
            lblIdPregunta.Name = "lblIdPregunta";
            lblIdPregunta.Size = new Size(26, 20);
            lblIdPregunta.TabIndex = 5;
            lblIdPregunta.Text = "1.-";
            // 
            // ucPregunta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(lblIdPregunta);
            Controls.Add(label1);
            Controls.Add(txtArgumento);
            Controls.Add(rbNo);
            Controls.Add(rbSi);
            Controls.Add(txtPregunta);
            Name = "ucPregunta";
            Size = new Size(979, 68);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbSi;
        private RadioButton rbNo;
        private Label label1;
        private Label lblIdPregunta;
        public RichTextBox txtPregunta;
        public RichTextBox txtArgumento;
    }
}
