using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmSecretaria : Form
    {
        private ControlSecretaria controlSecretaria = new ControlSecretaria();
        private Secretaria Secretaria { get; set; }
        public frmSecretaria(int idx)
        {
            InitializeComponent();
            lblHoraFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Secretaria = controlSecretaria.ConsultarSecretaria(idx);
            if (Secretaria != null)
            {
                lblBienvenida.Text = "Bienvenido " + Secretaria.Nombre;
            }
            else
            {
                lblBienvenida.Text = "Bienvenido Secretaria";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
