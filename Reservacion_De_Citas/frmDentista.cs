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

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
