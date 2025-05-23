namespace Controles
{
    partial class ucPreguntasHC
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
            label1 = new Label();
            flpTodasLasPreguntas = new FlowLayoutPanel();
            lblMensajeBusqueda = new Label();
            cbBusqueda = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnGuardar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(394, 38);
            label1.TabIndex = 69;
            label1.Text = "Preguntas de Historia Clinica";
            // 
            // flpTodasLasPreguntas
            // 
            flpTodasLasPreguntas.AutoScroll = true;
            flpTodasLasPreguntas.Dock = DockStyle.Bottom;
            flpTodasLasPreguntas.FlowDirection = FlowDirection.TopDown;
            flpTodasLasPreguntas.Location = new Point(0, 255);
            flpTodasLasPreguntas.Name = "flpTodasLasPreguntas";
            flpTodasLasPreguntas.Size = new Size(1034, 449);
            flpTodasLasPreguntas.TabIndex = 70;
            // 
            // lblMensajeBusqueda
            // 
            lblMensajeBusqueda.Anchor = AnchorStyles.None;
            lblMensajeBusqueda.AutoSize = true;
            lblMensajeBusqueda.FlatStyle = FlatStyle.Flat;
            lblMensajeBusqueda.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeBusqueda.ForeColor = SystemColors.InactiveCaption;
            lblMensajeBusqueda.Location = new Point(505, 105);
            lblMensajeBusqueda.Name = "lblMensajeBusqueda";
            lblMensajeBusqueda.Size = new Size(208, 23);
            lblMensajeBusqueda.TabIndex = 73;
            lblMensajeBusqueda.Text = "Solo se aceptan numeros";
            lblMensajeBusqueda.Visible = false;
            // 
            // cbBusqueda
            // 
            cbBusqueda.Anchor = AnchorStyles.None;
            cbBusqueda.BackColor = SystemColors.ButtonFace;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(125, 104);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(364, 28);
            cbBusqueda.TabIndex = 72;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 109);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 71;
            label3.Text = "Buscar:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(763, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 212);
            panel1.TabIndex = 74;
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
            // ucPreguntasHC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(panel1);
            Controls.Add(lblMensajeBusqueda);
            Controls.Add(cbBusqueda);
            Controls.Add(label3);
            Controls.Add(flpTodasLasPreguntas);
            Controls.Add(label1);
            Name = "ucPreguntasHC";
            Size = new Size(1034, 704);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpTodasLasPreguntas;
        private Label lblMensajeBusqueda;
        private ComboBox cbBusqueda;
        private Label label3;
        private Panel panel1;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnGuardar;
    }
}
