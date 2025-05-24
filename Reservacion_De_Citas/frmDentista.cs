using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Formularios
{
    public partial class frmDentista : Form
    {
        private ControlMedico controlDentista = new ControlMedico();
        private Medico Dentista { get; set; }
        public frmDentista(int idx)
        {
            InitializeComponent();
            Dentista = controlDentista.ConsultarMedico(idx);
            if (Dentista != null)
            {
                lblBienvenida.Text = "Bienvenido " + Dentista.Nombre;
            }
            else
            {
                lblBienvenida.Text = "Bienvenido Dentista";
            }

            lblHoraFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e) //btnAgenda
        {
            abrirFormularioHijo(new frmAgenda(Dentista.IdPersona, "dent"));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Form formularioAactivo = null;
        private void abrirFormularioHijo(Form hijo)
        {
            if (formularioAactivo != null)
            {
                formularioAactivo.Close();
            }
            formularioAactivo = hijo;
            formularioAactivo.TopLevel = false;
            formularioAactivo.FormBorderStyle = FormBorderStyle.None;
            formularioAactivo.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(formularioAactivo);
            panelFormulario.Tag = formularioAactivo;
            formularioAactivo.BringToFront();
            formularioAactivo.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmCitas( Dentista.IdPersona, "dent"));
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmConsultas( Dentista.IdPersona));
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmAlmacen());
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmPacientes( Dentista.IdPersona));
        }

        private void btnPreguntasHC_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmPreguntasHC());
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmPresupuestos());
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmRecetas( Dentista.IdPersona ));
        }
    }
}
